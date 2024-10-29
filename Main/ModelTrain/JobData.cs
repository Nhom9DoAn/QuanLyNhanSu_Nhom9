using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ModelTrain
{
    internal class JobData
    {
        [LoadColumn(0)]
        public float WorkYear { get; set; }

        [LoadColumn(1)]
        public string ExperienceLevel { get; set; }

        [LoadColumn(2)]
        public string EmploymentType { get; set; }

        [LoadColumn(3)]
        public string JobTitle { get; set; }

        [LoadColumn(4)]
        public float SalaryInUSD { get; set; }

        [LoadColumn(5)]
        public float RemoteRatio { get; set; }

        [LoadColumn(6)]
        public string CompanySize { get; set; }

    }
}
