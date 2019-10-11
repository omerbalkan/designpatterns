using System.Reflection;
using System.Linq;
using System; 
using System.Collections.Generic;

namespace DesignPatterns{
    [AttributeUsage(AttributeTargets.Class)]
    public class ObserverNameAttribute : Attribute{
        public string ObserverName { get; set; }
    }
    abstract class Observer{
        public string ObserverName { get; set; }

        public Observer(){
            var attr = this.GetType().GetCustomAttribute(typeof(ObserverNameAttribute), true) as ObserverNameAttribute; 
            if (attr is null)
                throw new Exception("defining attribute was forgatten while writing this class");

            ObserverName = attr.ObserverName; 
            // or: 
            // ObserverName = this.GetType().Name; 
        }

        public virtual void Notify(string message){
            $"there is a message for {ObserverName} customer : {message}".Print(); 
        }
    }
    [ObserverName(ObserverName = "Halk")]
    class People : Observer{

    }
    [ObserverName(ObserverName = "ozel")]
    class Vip : Observer{

    }
    [ObserverName(ObserverName="sirket")] 
    class Company : Observer{

    }

    class StoreManager {

        List<Observer> observers = new List<Observer>(); 
        public void AddObserver (Observer obs) => observers.Add(obs); 
        public void DiscountNotify(){
            foreach(var item in observers)
                item.Notify("sale time"); 
        }
    }
}