using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouCode
{
    //TODO: is this the correct way to throw such an exception?
    class UnexpectedGameEngineInitiallizationException : Exception
    {
        private const string k_ExceptionMessage = "Game Engine initialization attampted with incorrect parameters.";
        
        public UnexpectedGameEngineInitiallizationException()
        {
            throw new Exception(k_ExceptionMessage);
        }
    }
}
