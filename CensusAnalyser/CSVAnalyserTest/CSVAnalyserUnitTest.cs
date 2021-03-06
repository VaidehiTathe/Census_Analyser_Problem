using NUnit.Framework;
using CensusAnalyser;

namespace CSVAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenCSVFile_WhenNumberOfRecordsMatches_ShoulReturnTrue()
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Census_Analyser_Problem\CensusAnalyser\CensusAnalyser\IndiaStateCensusData.csv";
            int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
            int records = StateCensusAnalyser.GetStateCensusRecords(filePath);
            Assert.AreEqual(CSVRecords, records);
        }

        [Test]
        public void GivenCSVFilePath_WhenIncorrect_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"E:\CodinClub\Census_Analyser_Problem\CensusAnalyser\CensusAnalyser\IndiaStateCensusData.csv";
                int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
                int records = StateCensusAnalyser.GetStateCensusRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
            catch (StateCensusAnalyserException e)
            {
                Assert.AreEqual(StateCensusAnalyserException.ExceptionType.INVALID_PATH, e.Type);
                //Assert.AreEqual(e.Message,"Entered wrong path");
            }
        }

        [Test]
        public void GivenCSVFileName_WhenIncorrectTypeOfFile_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"E:\CodinClub\Census_Analyser_Problem\CensusAnalyser\CensusAnalyser\IndiaStateCensusData.txt";
                int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
                int records = StateCensusAnalyser.GetStateCensusRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
            catch (StateCensusAnalyserException e)
            {

                Assert.AreEqual("Name of the file is incorrect", e.Message);
            }

        }
    }
}