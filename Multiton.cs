using System.Collections.Generic;
using System; 

namespace DesignPatterns {
    class Tool{
        private static Dictionary<string, Tool> tools = new Dictionary<string, Tool>(); 
        public string Category { get; set; }
        private Tool(){}
        public static Tool GenerateToolAsMultiton(string category){
            if (!tools.ContainsKey(category))
                tools.Add(category, new Tool{Category = category}); 
            return tools[category];  
        }
    }
}