﻿using System.Data;

namespace PersistenceMap.Interception
{
    internal class MockedConnectionProvider : IConnectionProvider
    {
        private readonly IDataReader _dataReader;

        public MockedConnectionProvider(IQueryCompiler compiler, IDataReader dataReader)
        {
            _dataReader = dataReader;
            QueryCompiler = compiler;
        }

        public string Database { get; set; }

        public IQueryCompiler QueryCompiler { get; set; }

        public void Dispose()
        {
        }

        public IDataReaderContext Execute(string query)
        {
            return new DataReaderContext(_dataReader, null, null);
        }

        public int ExecuteNonQuery(string query)
        {
            return 0;
        }
    }
}
