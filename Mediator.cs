using System; 
using System.Collections.Generic;
namespace DesignPatterns{
    abstract class CourseMember{
        protected Mediator mediator; 
        public CourseMember(Mediator mediator){
            this.mediator = mediator; 
        }
    }
    abstract class Student : CourseMember{
        public abstract void SendQuestion(string question); 
        public abstract void ReceiveAnswer(string answer); 
        public Student(Mediator mediator) : base (mediator){} 
    }
    abstract class Teacher : CourseMember  {
        public abstract void SendAnswer(string answer); 
        public abstract void ReceiveQuestion(string queestion); 
        public Teacher(Mediator mediator) : base (mediator){} 
    }

    class Mediator{
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }


    }
}