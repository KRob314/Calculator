using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public class Calculations: ObservableCollection<Calculation>
    {
    }

    public class Calculation : Tuple<string, string>
    {
        public Calculation(string expression, string result) : base(expression, result) { }
        public string Expression => this.Item1;
        public string Result => this.Item2;
    }
}
