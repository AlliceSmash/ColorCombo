using System.Collections.Generic;

namespace ColorCombination.Test
{
    class TestData
    {
        public static string failmsg = "Can not unlock master panel.";

        public static List<MyChip> Failure1
        {
            get
            {
                return new List<MyChip>
                {
                    new MyChip(){Left="blue", Right="green"},
                    new MyChip(){Left="blue", Right="yellow"},
                    new MyChip(){Left="red",Right="orange"},
                    new MyChip(){Left="red", Right="green"},
                    new MyChip(){Left="yellow",Right="red"},
                    new MyChip(){Left="orange", Right="purple"} 
                };
            }
        }

        public static string FailureOutput
        {
            get
            {
                return  failmsg;
            }
        }

        public static List<MyChip> Success1
        {
            get
            {
                return new List<MyChip>
                {
                    new MyChip(){Left="blue", Right="green"},
                    new MyChip(){Left="blue", Right="yellow"},
                    new MyChip(){Left="red",Right="orange"},
                    new MyChip(){Left="red", Right="green"},
                    new MyChip(){Left="yellow",Right="red"},
                    new MyChip(){Left="orange", Right="red"}
                };
            }
        }

        public static string SuccessExpectedOutput1
        {
            get { return "blue, yellow\r\nyellow, red\r\nred, orange\r\norange, red\r\nred, green\r\n"; }
        }

        public static List<MyChip> Success2
        {
            get
            {
                return new List<MyChip>
                {
                    new MyChip(){Left="blue", Right="green"},
                    new MyChip(){Left="blue", Right="green"},
                    new MyChip(){Left="blue", Right="yellow"},
                    new MyChip(){Left="green",Right="yellow"},
                    new MyChip(){Left="orange", Right="red"},
                    new MyChip(){Left="red", Right="green"},
                    new MyChip(){Left="red", Right="orange"},
                    new MyChip(){Left="yellow",Right="blue"},
                    new MyChip(){Left="yellow",Right="red"}
                };
            }
        }

        public static string SuccessExpectedOutput2
        {
            get
            {
                return "blue, green\r\ngreen, yellow\r\nyellow, blue\r\nblue, yellow\r\nyellow, red\r\nred, orange\r\norange, red\r\nred, green\r\n";
            }
        }

        public static List<MyChip> Failure2
        {
            get
            {
                return new List<MyChip>
                {
                    new MyChip(){Left="blue", Right="green"},
                    new MyChip(){Left="blue", Right="yellow"},
                    new MyChip(){Left="red",Right="orange"},
                    new MyChip(){Left="red", Right="green"},
                    new MyChip(){Left="yellow",Right="red"},
                    new MyChip(){Left="orange", Right="yellow"}
                };
            }
        }

        public static List<MyChip> Success3
        {
            get
            {
                return new List<MyChip>
                {
                    new MyChip(){Left="blue", Right="green"},
                    new MyChip(){Left="blue", Right="green"}
                };
            }
        }

        public static string SuccessExpectedOutput3
        {
            get
            {
                return "blue, green\r\n";
            }
        }

        public static List<MyChip> Failure3
        {
            get
            {
                return new List<MyChip>
                {
                    new MyChip(){Left="blue", Right="green"}
                };
            }
        }
    }
}
