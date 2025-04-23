using CCaptureWinForm.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCaptureWinForm.Infrastructure.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Database connection string is not configured in appsettings.json");
            }
        }

        public async Task<List<string>> GetBatchClassNamesAsync()
        {
            return await ExecuteQueryAsync("SELECT name FROM batch_class ORDER BY name", reader => reader.GetString(0));
        }

        public async Task<List<string>> GetFieldNamesAsync(string batchClassName)
        {
            var query = @"
                SELECT field_name 
                FROM public.batch_field_def 
                WHERE id_batch_class = (SELECT id_batch_class FROM public.batch_class WHERE name = @batchClassName) 
                ORDER BY field_name ASC";

            return await ExecuteQueryAsync(query, reader => reader.GetString(0), ("@batchClassName", batchClassName));
        }

        public async Task<List<string>> GetPageTypesAsync(string batchClassName)
        {
            var query = @"
                SELECT pt.name 
                FROM public.batch_class bc 
                JOIN public.document_class dc ON dc.id_batch_class = bc.id_batch_class 
                JOIN public.page_type pt ON pt.id_document_class = dc.id_document_class 
                WHERE bc.name = @batchClassName 
                ORDER BY pt.name ASC";

            return await ExecuteQueryAsync(query, reader => reader.GetString(0), ("@batchClassName", batchClassName));
        }

        private async Task<List<T>> ExecuteQueryAsync<T>(string query, Func<NpgsqlDataReader, T> map, params (string, object)[] parameters)
        {
            var results = new List<T>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        foreach (var (name, value) in parameters)
                        {
                            cmd.Parameters.AddWithValue(name, value);
                        }

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                results.Add(map(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database query execution failed.", ex);
            }
            return results;
        }
    }
}
