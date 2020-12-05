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
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Welcome to {cellModel}");
                Console.ResetColor();
            
            }

        
        
        public void TurnOFF (bool turnOn) {

            on = false;

               Console.WriteLine();
               Console.WriteLine();
               Console.WriteLine("Goodbye");

        }
                
        
        
        public void SendMessage (string messageNumber, string cellMessage) {

            if (on == true) {
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.Write($"Message sent to number: {messageNumber}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Message sent: {cellMessage}");
                Console.WriteLine();
                Console.ResetColor();
            } 
            
            else {
                   
                   Console.Clear();
                   Console.WriteLine();
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine("Please turn on cellphone");
                   Console.ResetColor();
                
                 }
        }
    
        
        
        public void MakeCall (string phoneNumber) {

           if (on == true) {
               
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Cyan;
               Console.WriteLine($"Calling ... {phoneNumber}");
               Console.ResetColor();
               Console.WriteLine();
            
            }

           else {
               
               Console.Clear();
               Console.WriteLine();
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("Please turn on cellphone");
               Console.ResetColor();
            
            }

        }
    }
}
