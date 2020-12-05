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

            cellphone.on = false;
               
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
             
             Console.ForegroundColor = ConsoleColor.Green;
             Console.Write("*** Cellphone is currently turned off ***");
             Console.ResetColor();
             Console.WriteLine();
             Console.WriteLine();

    do {

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

                if (cellphone.on == true) {
                    
                    Console.WriteLine();
                    Console.WriteLine("Cellphone is already turned on");
                    
                    } 
                
                cellphone.TurnOn(cellphone.on,cellphone.cellModel);

                 do {
            
            Console.WriteLine();
            Console.WriteLine($"Please type in your password to unlock {cellphone.cellModel} :\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            password = Console.ReadLine();
            Console.ResetColor();
            PerformLogin(password);
            
                    } while (password != "071188");

            bool PerformLogin (string password) {

                if (password == "071188") {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Welcome to {cellphone.cellModel}");
                    Console.WriteLine();
                    Console.WriteLine("Cellphone is now turned on");
                    Console.ResetColor();
                    return true;
                
                    } else {
                    
                    Console.Clear();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password Denied, please try again");
                    Console.ResetColor();
                    return false; 
            
                    }
                }

                break;
            
            
                
                case 2: 

                if (cellphone.on == false) {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("Cellphone is already turned off");
                    Console.ResetColor();
                }
                
                cellphone.TurnOFF(cellphone.on);

                break;
            
            
            
                case 3: 

                if (cellphone.on == false) {

                   Console.Clear();
                   Console.WriteLine();
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine("Please turn on cellphone");
                   Console.ResetColor();
                
                } 
                
                else {
                
                Console.WriteLine();
                Console.WriteLine("Please type the number you wish to call: \n");
                string phoneNumber = Console.ReadLine();
            
                cellphone.MakeCall(phoneNumber);

                }
            
                break;


                
                case 4:

                if (cellphone.on == false) {

                   Console.Clear();
                   Console.WriteLine();
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine("Please turn on cellphone");
                   Console.ResetColor();
                
                } 

                else {
                    
                Console.WriteLine();
                Console.WriteLine("Please type the number you wish to send a SMS message: \n");
                string messageNumber = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Please type your message below:\n ");
                string cellMessage = Console.ReadLine();

                cellphone.SendMessage(messageNumber,cellMessage);

                }
            
                break;



                case 5:

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine();
                Console.WriteLine($"model: {cellphone.cellModel}"); 
                Console.WriteLine();
                Console.WriteLine($"color: {cellphone.cellColor}"); 
                Console.WriteLine();
                Console.WriteLine($"width: {cellphone.cellWidth} mm"); 
                Console.WriteLine();
                Console.WriteLine($"height: {cellphone.cellHeight} mm"); 
                Console.WriteLine();
                Console.ResetColor();
        
                break;
        
        
        
                default: 
                
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please choose a valid option number");
                Console.ResetColor();
        
                break;
    
            } 
            
    
    } while (choice != 2);
        
        
        }
    }
}
        
        
        
        
        
        
        
        
        
        
        
