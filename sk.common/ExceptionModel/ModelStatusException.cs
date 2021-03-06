﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sk.common.ExceptionModel
{
    public class ModelStatusException: Exception
    {
        public ResponseModelStatus ResponseModelMessage;

        public ModelStatusException(string message) : base(message)
        {
        }

        public ModelStatusException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ModelStatusException(string message, ResponseModelStatus responseModelStatus) : base(message) 
        {
            ResponseModelMessage = responseModelStatus;
        }

        public ModelStatusException(ResponseModelStatus responseModelStatus)
        {
            ResponseModelMessage = responseModelStatus;
        }
    }
}
