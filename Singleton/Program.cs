namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Singleton Design Pattern";
            
            //Below line gives error because class is protected
            //var test = new SingletonImplementation();
        
            var instace1 = SingletonImplementation.Instance;
            var instace2 = SingletonImplementation.Instance;  
            
            if(instace1==instace2 && instace2 == SingletonImplementation.Instance)
            {
                Console.WriteLine("Instances are same");
            }

            instace1.Log("Method called from Instance 1");
            instace2.Log("Method called from instance 2");
            SingletonImplementation.Instance.Log("Method called withou object creation");
        
        }
    }
}