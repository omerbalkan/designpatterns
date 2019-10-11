using System; 
namespace DesignPatterns{
    abstract class CalculateTemplate{
        protected abstract int BaseCalculate(int knowns); 
        protected abstract int Reduce(int unknowns); 
        public virtual int Calculate(int knowns, int unknowns){
            return BaseCalculate(knowns) - Reduce(unknowns); 
        }
    }
    class ChildrenCalculate : CalculateTemplate{
        protected override int BaseCalculate(int knowns){
            return knowns * 10; 
        }
        protected override int Reduce(int unknowns){
            return unknowns / 10; 
        }
    }
    class WomenCalculate : CalculateTemplate{
        protected override int BaseCalculate(int knowns){
            return knowns * 9; 
        }
        protected override int Reduce(int unknowns){
            return unknowns / 9; 
        }
    }
    class MenCalculate : CalculateTemplate{
        protected override int BaseCalculate(int knowns){
            return knowns * 8; 
        }
        protected override int Reduce(int unknowns){
            return unknowns / 8; 
        }
    }
}