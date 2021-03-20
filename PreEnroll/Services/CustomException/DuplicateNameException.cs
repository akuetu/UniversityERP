using System;

namespace Enrollment.Services.CustomException
{
    [Serializable]
    public class DuplicateNameException: SystemException
    {
        public string Entity { get; set; }
        public DuplicateNameException() : base() { }
        public DuplicateNameException(string message) : base(message) { 
        
        //log error
        }
        public DuplicateNameException(string message, Exception exception) : base(message, exception) { }
        public DuplicateNameException(string message, string entity) : base(message)
        {
            Entity = entity;
        }

        

    }
}
