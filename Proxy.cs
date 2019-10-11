using System; 

namespace DesignPatterns{
    interface ICredit{
        int Calculate(); 
    }
    class CreditManager : ICredit{
        public int Calculate(){
            "your credit is being prepared".Print(); 
            "and its ready".Print(); 
            return 100; 
        }
    }
    class CreditManagerProxy : ICredit{
        private CreditManager cm; 
        private int _cachedValue; 

        public int Calculate(){
            if (cm is null){
                cm = new CreditManager(); 
                _cachedValue = cm.Calculate(); 
            }
            else{
                "your credit has already been prepared".Print(); 
            }
            return _cachedValue; 
        }
    }
}