﻿using System;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FileCounter
{
    ///<inheritdoc/>
    public class CsvFileReader : IReader
    {
        private readonly string path;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="configuration">Конфигурация.</param>
        public CsvFileReader(IConfiguration configuration)
        {
            path = configuration["Path"];
        }

        public string[] Read()
        {
            return ReadInputData().Split(";");
        }

        private string ReadInputData()
        {
            try
            {
                return System.IO.File.ReadLines(path, Encoding.Default).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
