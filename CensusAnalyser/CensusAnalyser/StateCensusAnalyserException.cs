using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    [Serializable]
    public class StateCensusAnalyserException: Exception
    {
        public enum ExceptionType
        {
            INVALID_PATH
        }
        public ExceptionType Type { get; set; }

        public StateCensusAnalyserException(string message):base(message)
        {
            this.Type = Type;
        }

    }
}
