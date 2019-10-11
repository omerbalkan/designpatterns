using System.Collections.Generic;
using System; 
namespace DesignPatterns {
    class Stock{
        public string StockName { get; set; }
        public double Amount { get; set; }

        public void Buy(double amount) => Amount += amount; 
        public void Sell(double amount) => Amount -= amount;
    }

    abstract class Order{
        protected readonly Stock stock; 
        protected readonly double amount; 
        public Order(Stock stock, double amount){
            this.stock=stock; 
            this.amount = amount; 
        }
        public abstract void ExecuteCommand(); 
    }

    class SellOrder : Order{
        public SellOrder(Stock stock, double amount) : base(stock, amount){} 
        public override void ExecuteCommand() => stock.Sell(amount); 
    }
    class BuyOrder : Order{
        public BuyOrder(Stock stock, double amount) : base(stock, amount){} 
        public override void ExecuteCommand() => stock.Buy(amount); 
    }

    enum Orders{
        Sell, Buy
    }

    class StockController {
        private readonly Stock stock; 
        public StockController(Stock stock){
            this.stock = stock;
        }
        private List<Order> orders = new List<Order>(); 
        public void TakeOrder(Orders order, double amount){
            orders.Add(order == Orders.Sell ? new SellOrder(stock, amount) as Order 
            : new BuyOrder(stock, amount)); 
        }
        public void PlaceOrders(){
            orders.ForEach(s => s.ExecuteCommand()); 
            orders.Clear(); 
        }
    }
}