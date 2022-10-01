using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singlaton implementation example using logger 
    /// </summary>
    public class SingletonImplementation
    {
        //Onely one instance of this object is created becuase it's static 
        private static SingletonImplementation? _loggerInstance;


        /// <summary>
        /// instance access
        /// </summary>
        /// Becuase of public static method above instance will be accesible globally and only one instance will be available.
        public static SingletonImplementation Instance
        {
            get 
            {
                if(_loggerInstance == null)
                {
                    _loggerInstance = new SingletonImplementation();
                }
                return _loggerInstance;
            }
        }

        protected SingletonImplementation()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine("Message is from {0}",message);
        }

    }
}
