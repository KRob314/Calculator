using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    internal class Compute
    {
        public string Evaluate(string expression)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            var finalResult = dataTable.Compute(expression, string.Empty);

            return finalResult.ToString();
        }
    }
}
