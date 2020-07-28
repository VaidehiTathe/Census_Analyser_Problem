using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CensusAnalyser
{
    public class StateCensusAnalyser
    {
        private readonly string filePath;
        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;

        }
        public static int GetStateCensusRecords(string filepath)
        {
            string[] numOfRecords = File.ReadAllLines(filepath);
            return numOfRecords.Length - 1;
        }
        
    }
}
