using System;

namespace CensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Census_Analyser_Problem\CensusAnalyser\CensusAnalyser\IndiaStateCensusData.csv";
            int csvStateCensusRecords = CSVStateCensusAnalyser.GetRecords(filePath);
            int stateCensusRecords = StateCensusAnalyser.GetStateCensusRecords(filePath);
            Console.WriteLine("csv state census records:" + csvStateCensusRecords);
            Console.WriteLine("state census records:" + stateCensusRecords);
        }
    }
}
