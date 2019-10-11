using System.Collections.Generic;
using System; 
namespace DesignPatterns{
    class One{
        private string _name; 
        private string _surname; 
        public string Name {
            get => _name; 
            set{
                forUndo.Push($"name={_name}");
                _name = value; 
            }}
        public string Surname {
            get=>_surname; 
            set{
                forUndo.Push($"surname={_surname}");
                _surname = value; 
            }
        }

        private readonly Stack<string> forUndo = new Stack<string>(); 
        private readonly Stack<string> forRedo = new Stack<string>();

        public void Undo(){
            if (forUndo.Count > 0){
                var next = forUndo.Pop(); 
                var p = next.Split('=');

                if (p[0] == "name"){
                    forRedo.Push($"name={_name}"); 
                    _name = p[1]; 
                }
                else{
                    forRedo.Push($"surname={_surname}"); 
                    _surname = p[1]; 
                }
            }
        }
        public  void Redo(){
            if (forRedo.Count> 0){
                var next = forRedo.Pop(); 
                var p = next.Split('='); 
                forUndo.Push(next); 
                if (p[0] == "name")
                    _name = p[1]; 
                else
                    _surname = p[1];
            }
        }

    }
}