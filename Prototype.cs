using System; 

namespace DesignPatterns{
    class Person{
        public string Name { get; set; }
        public string Surname { get; set; } 

        public virtual Person Clone(){
            return MemberwiseClone() as Person; 
        }
    }
    class Employee : Person {
        public string Department { get; set; } 
        
    }
}