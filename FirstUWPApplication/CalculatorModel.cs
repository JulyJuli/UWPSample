using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWPApplication
{
  public class CalculatorModel
    {
        private int value1 = 0;
        private int value2 = 0;

        public CalculatorModel(int val1, int val2) {
            this.value1 = val1;
            this.value2 = val2;
        }

        public int Add() {
            return value1 + value2;
        }

        public int Sub()
        {
            return value1 - value2;
        }
    }
}
