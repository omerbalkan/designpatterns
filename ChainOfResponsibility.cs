using System; 
namespace DesignPatterns{
    abstract class CheckBase{
        public double MaxConfirm{get;set;}
        public CheckBase UpperChecker { get; set; }

        public virtual bool Confirmation(double amount){
            if (amount < MaxConfirm)
                return true; 
            bool? result = UpperChecker?.Confirmation(amount); 
            return result is null ? false : true; 
        }
    }
}