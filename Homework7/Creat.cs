using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class Creat
    {


        public  string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string  Phone { get; set; }
        public Creat()
        {

        }
        public void Enter()
        {
            Console.WriteLine(" 1. Sign ");
            Console.WriteLine(" 2. Login ");
            int number = int.Parse(Console.ReadLine()); ;

            if (number ==1)     {    Sign();    }
            if (number == 2 )   {    Login();  }
            else { Console.WriteLine(" Mistake number  Try again!"); Enter();  } ;
          
        }
        public void Sign()
        {
            Console.Write(" FullName: ");
            string FullName = Console.ReadLine();

            Console.Write(" UserName: ");
            string UserName = Console.ReadLine();

            Console.Write(" Password: ");
            string Password = Console.ReadLine();

            Console.WriteLine("Phonumber: ");
            string phone = Console.ReadLine();

         

            string file = "C:\\HP\\PAP.txt";
            if (!Directory.Exists("C:\\HP\\PAP.txt"))
            {
                File.Create("C:\\HP\\PAP.txt");
            }
            else {  Console.WriteLine(" Fayil mavjud "); }
            using (StreamWriter streamWriter = new StreamWriter(file, true))
            {
                streamWriter.WriteLine($" Sizning Familyangiz {FullName}");
                //No need to call the Flush and Close Method
            }
            Console.WriteLine( " Royxatga olindingiz!! ");

            Enter();    
        }

        public void Login()
        {
            Console.Write( " Enter Your UserName: ");
            string username1 = Console.ReadLine();   
            
            Console.Write( " Enter Your Password: ");
            string password1 = Console.ReadLine();

            if (username1== UserName && password1 == Password) {      Issue();     }
            else { Sign(); }

        }
        public void Issue()
        {
            Console.WriteLine($" Siznimg Familyangiz:  {FullName} ");
            Console.WriteLine($" Siznimg Ismingiz:       {UserName} ");
            Console.WriteLine($" Siznimg Parolingiz      {Password} ");
            Console.WriteLine($" Siznimg Telfon Raqamingiz:  {Phone} ");
        }
        public Creat(string fullName, string userName, string password, string phone)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            Phone = phone;  
        }

      
    }
}
