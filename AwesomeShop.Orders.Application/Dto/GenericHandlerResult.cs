using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShop.Orders.Application.Dto
{
    public class GenericHandlerResult<T> where T : class
    {
        public GenericHandlerResult(string message, T data, bool sucess, List<ValidationObject> validationObjects)
        {
            Message = message;
            Data = data;
            Sucess = sucess;
            ValidationObjects = validationObjects;
        }

        public string Message { get; private set; }
        public T Data { get; private set; }
        public bool Sucess { get; private set; }
        public List<ValidationObject> ValidationObjects { get; set; }
    }

    public class ValidationObject
    {
        public ValidationObject(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }
    }
}