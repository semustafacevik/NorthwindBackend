using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }
     
        public SuccessResult(string message) : base(true, message)
        {
        }

    }
}
