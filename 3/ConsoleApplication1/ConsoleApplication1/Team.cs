using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Properties
{
    public class Team
    {
        public static List<LabWorker> data = new List<LabWorker>();
        public LabWorker this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
}