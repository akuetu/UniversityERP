using System;

namespace Enrollment.Services.CustomException
{
    [Serializable]
    public class DuplicateNameException: SystemException
    {
        public DuplicateNameException()
        {
        }
        public DuplicateNameException(string message)
           : base($"Invalid Name: {message}")
        {

        }
        
    }
}
