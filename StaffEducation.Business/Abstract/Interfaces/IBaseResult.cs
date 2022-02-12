using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Business.Abstract
{
    public class BaseResult<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }
        public ValidationErrorType ResultType { get; set; } = ValidationErrorType.Success;
        public List<ValidationError> Errors { get; set; }
        public BaseResult()
        {
            Errors = new List<ValidationError>();
        }
    }

    public class ValidationError
    {
        public string FieldName { get; private set; }
        public string Message { get; private set; }

        public ValidationError(string fieldName, string message)
        {
            FieldName = fieldName;
            Message = message;
        }
    }
    public enum ValidationErrorType
    {
        Error,
        Success
    }
}
