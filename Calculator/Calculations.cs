using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculations
    {
        public double resultValue = 0;
        public string operationPerformed = "";
        public bool isOperationPerformed = false;


        public string keyPressed(string textInput, string key)
        {
            if (textInput == "0" || isOperationPerformed)
                textInput = "";

            isOperationPerformed = false;
            return  textInput + key;
        }
       

    }

   
}
