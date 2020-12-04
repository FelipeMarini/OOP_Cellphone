using System;
namespace OOP_Cellphone.Classes
{
    public class Mobile
    {
        public string cellModel;
        public string cellColor;
        public float cellWidth;
        public float cellHeight;
        public bool on;


        public void TurnOn (bool turnOn, string cellModel) {

            on = true;
                
                Console.WriteLine();
                Console.WriteLine($"Welcome to {cellModel}");
            
            }

        
        
        public void TurnOFF (bool turnOn) {

            on = false;

               Console.WriteLine();
               Console.WriteLine("Goodbye");

        }
                
        
        
        public void SendMessage (int messageNumber, string cellMessage) {

            if (on == true) {

                Console.Write($"Message sent to number: {messageNumber}");
                Console.WriteLine();
                Console.WriteLine($"Message sent: \n {cellMessage}");
            } 
            
            else {Console.WriteLine("Please turn on cellphone");}
        }
    
        
        
        public void MakeCall (int phoneNumber) {

           if (on == true) {
               
               Console.WriteLine();
               Console.WriteLine($"Calling ... {phoneNumber}");
            }

           else {
               
               Console.WriteLine();
               Console.WriteLine("Please turn on cellphone");
            }

        }
    }
}
