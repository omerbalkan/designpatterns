using System; 

namespace DesignPatterns{
    interface IMessageSender{
        void Send(string message); 
    }
    class SmsSender : IMessageSender{
        public void Send(string message){
            $"your message was send via 'sms' supplier. message : {message}".Print(); 
        }
    }
    class EmailSender : IMessageSender{
        public void Send(string message){
            $"your message was send via 'e-mail' supplier. message : {message}".Print(); 
        }
    }
    class CustomerManager {
        public IMessageSender Sender { get; set; }

        public void Update(){
            if (Sender is null)
                "you dont have any message sender".Print(); 
            else
                Sender.Send("Updated"); 
        }
    }
}