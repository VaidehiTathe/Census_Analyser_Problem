using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CensusAnalyser
{
    public class CSVStateCensusAnalyser
    {
        public static int GetRecords(string filePath)
        {
            try
            {
                int countOfRecords = 0;
                string[] data = File.ReadAllLines(filePath);
                IEnumerable<string> records = data;
                foreach (var elements in records)
                {
                    countOfRecords++;
                }
                return countOfRecords - 1;
            }
            catch(StateCensusAnalyserException)
            {
                throw new StateCensusAnalyserException("Give correct path");
            }

            catch (FileNotFoundException)
            {
                throw new StateCensusAnalyserException("Incorrect file name");
            }
        }
    }
}
