using System;

namespace DesignPatterns{
    class Product{
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Ucret { get; set; } 
    }
    abstract class ProductBuilder {
        protected readonly Product product = new Product(); 
        public abstract void SetProps(); 
        public abstract void ApplyDiscount(); 

        public virtual Product GetProduct(){
            return product; 
        }
    }
    class OldProductBuilder : ProductBuilder{
        public override void SetProps(){
            product.Marka = "old marka"; 
            product.Model= "old model"; 
            product.Ucret = 101.5; 
        }
        public override void ApplyDiscount(){
            product.Ucret -= 15.25; 
        }
    }
    class NewProductBuilder : ProductBuilder{
        public override void SetProps(){
            product.Marka = "new marka"; 
            product.Model= "new model"; 
            product.Ucret = 150.75;  
        }
        public override void ApplyDiscount(){
            product.Ucret -= 10.30;  
        }
    }
    class ProductManager {
        private readonly ProductBuilder builder;
        public ProductManager(ProductBuilder builder){
            this.builder = builder; 
        }
        public Product GetProduct(){
            builder.SetProps(); 
            builder.ApplyDiscount(); 
            return builder.GetProduct(); 
        }
    }
}