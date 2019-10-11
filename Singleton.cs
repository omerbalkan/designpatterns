using System.IO;
using System; 

namespace DesignPatterns{
    class Spam{
        private static Spam _spam; 
        private Spam(){} 
        public static Spam GenerateAsSingleton(){
            return _spam ?? (_spam = new Spam()); 
        }
        public int TestProp { get; set; }
    }
}