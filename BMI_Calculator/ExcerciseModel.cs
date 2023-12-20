using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class APINinjaModel
    {
        public List<ExcerciseModel> Excercises { get; set; }
    }
    public class ExcerciseModel
    {
            public string name { get; set; }
            public string difficulty { get; set; }
    }
}
