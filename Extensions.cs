using System; 

namespace DesignPatterns{
    public static class Extensions{
        public static void Print(this object obj, string end = "\n"){
            Console.Write(obj + end); 
        }
    }
}