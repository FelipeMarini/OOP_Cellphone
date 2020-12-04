using System;

using OOP_Cellphone.Classes;

namespace OOP_Cellphone
{
    class Program
    {
        static void Main(string[] args)
        {   

            int choice;
            string password;


            Mobile cellphone = new Mobile();

            cellphone.on = true;
               
            Console.WriteLine();
            Console.Write("Please type cellphone model:  ");
            cellphone.cellModel = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Please type cellphone color: ");
            cellphone.cellColor = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please type cellphone width (mm):  ");
            cellphone.cellWidth = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please type cellphone height (mm):  ");
            cellphone.cellHeight = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            
             Console.WriteLine();
             Console.WriteLine($"----{cellphone.cellModel}----");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("[1] Turn ON (button)");
             Console.WriteLine();
             Console.WriteLine("[2] Turn OFF");
             Console.WriteLine();
             Console.WriteLine("[3] Make Phone Call");
             Console.WriteLine();
             Console.WriteLine("[4] Send SMS Message");
             Console.WriteLine();
             Console.WriteLine($"[5] About {cellphone.cellModel}");
             Console.WriteLine();
             Console.WriteLine();
             Console.Write("Please choose an option above: ");
             choice = int.Parse(Console.ReadLine());

            
            switch (choice) {

                
                case 1:  
                
                cellphone.TurnOn(cellphone.on,cellphone.cellModel);

                 do {
            
            Console.WriteLine();
            Console.WriteLine($"Please type in your password to unlock {cellphone.cellModel} :\n");
            Console.WriteLine();
            password = Console.ReadLine();
            PerformLogin(password);
            
                    } while (password != "071188");

            bool PerformLogin (string password) {

                if (password == "071188") {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Welcome to {cellphone.cellModel}");
                    Console.ResetColor();
                    return true;
                
                    } else {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password Denied");
                    Console.ResetColor();
                    return false; 
            
                    }
                }

                break;
            
            
                
                case 2: 
                
                cellphone.TurnOFF(cellphone.on);

                break;
            
            
            
                case 3:  
                
                Console.WriteLine("Please type the number you wish to call: \n");
                int phoneNumber = int.Parse(Console.ReadLine());
            
                cellphone.MakeCall(phoneNumber);
            
                break;


                
                case 4:

                Console.WriteLine("Please type the number you wish to send a SMS message: \n");
                int messageNumber = int.Parse(Console.ReadLine());
            
                Console.WriteLine("Please type your message below:\n ");
                string cellMessage = Console.ReadLine();

                cellphone.SendMessage(messageNumber,cellMessage);
            
                break;



                case 5:

                Console.WriteLine();
                Console.WriteLine($"{cellphone.cellModel}"); 
                Console.WriteLine();
                Console.WriteLine($"{cellphone.cellColor}"); 
                Console.WriteLine();
                Console.WriteLine($"{cellphone.cellWidth} mm"); 
                Console.WriteLine();
                Console.WriteLine($"{cellphone.cellHeight} mm"); 
                Console.WriteLine();
        
                break;
        
        
        
                default: Console.WriteLine("Please choose a valid option number");
        
                break;
        
            }
        }
    }
}
        
        
        
        
        
        
        
        
        
        
        
