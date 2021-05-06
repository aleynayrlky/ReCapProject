﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message) //default=dataya karşılık gelir ama listelemez
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
