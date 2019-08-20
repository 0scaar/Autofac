using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger logger;
        private IDataAccess dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this.logger = logger;
            this.dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessingInfo");
            logger.Log("Finished processing of the data.");
        }
    }
}
