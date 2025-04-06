using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritsu_sws120Project
{
    internal class CollegeProgram
    {
        private int programCode;
        private string programName;
        private string credentials;

        public int ProgramCode
        {
            get { return programCode; }
            set { programCode = value; }
        }
        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }

        public string Credentials
        {
            get { return credentials; }
            set { credentials = value; }
        }

        public CollegeProgram(int ProgramCode, string ProgramName, string Credentials)
        {
            programCode = ProgramCode;
            programName = ProgramName;
            credentials = Credentials;
        }

        public override string ToString()
        {
            return $"Program Code: {ProgramCode} \nProgram Name: {ProgramName} \nCredentials: {Credentials} ";
        }
    }
}
