using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger logger;

        public DataAccess(ILogger logger)
        {
            this.logger = logger;
        }

        public void LoadData()
        {
            Console.WriteLine("Loading Data");
            logger.Log("Loading data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
            logger.Log("Loading data");
        }
    }
}
