using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCaptureWinForm.Infrastructure.Services
{
    public class DatabaseService
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
            var batchClassNames = new List<string>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new NpgsqlCommand("SELECT name FROM batch_class ORDER BY name", conn))
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            batchClassNames.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve Batch Class Names from the database.", ex);
            }
            return batchClassNames;
        }
        public async Task<List<string>> GetFieldNamesAsync(string batchClassName)
        {
            var pageTypes = new List<string>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new NpgsqlCommand(
                        "SELECT field_name FROM public.batch_field_def " +
                        "WHERE id_batch_class = (SELECT id_batch_class FROM public.batch_class WHERE name = @batchClassName) " +
                        "ORDER BY field_name ASC", conn))
                    {
                        cmd.Parameters.AddWithValue("@batchClassName", batchClassName); 
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                pageTypes.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve Field Names from the database.", ex);
            }
            return pageTypes;
        }

        public async Task<List<string>> GetPageTypesAsync(string batchClassName)
        {
            var pageTypes = new List<string>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new NpgsqlCommand(
                        "SELECT pt.name " +
                        "FROM public.batch_class bc " +
                        "JOIN public.document_class dc ON dc.id_batch_class = bc.id_batch_class " +
                        "JOIN public.page_type pt ON pt.id_document_class = dc.id_document_class " +
                        "WHERE bc.name = @batchClassName " +
                        "ORDER BY pt.name ASC", conn))
                    {
                        cmd.Parameters.AddWithValue("@batchClassName", batchClassName);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                pageTypes.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve page types from the database.", ex);
            }
            return pageTypes;
        }


    }
}