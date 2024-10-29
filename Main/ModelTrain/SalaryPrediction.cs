using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ModelTrain
{
    internal class SalaryPrediction
    {
        [ColumnName("Score")]
        public float PredictedSalary { get; set; }
    }
}
