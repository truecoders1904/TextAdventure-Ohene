using System;

namespace Really
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are dreaming.\nYou see yourself as a child");
            Console.WriteLine("You are alone in a sandbox, digging a hole with your hands");
            Console.WriteLine("You watch in amazement as the edges of the hole begin to crumble inwards");

            Console.WriteLine("Do you allow curiosity to get the best of you? "); 
          
            string response = Console.ReadLine();


            if(response == "yes")
            {
                Console.WriteLine("You hear a voice crying out from the hole. . . ");
                Console.WriteLine("It is crying out for help . . . ");
                Console.WriteLine("a child's hands appear from the hole");
                Console.WriteLine("Do you grasp the hands to pull out the child?");
                response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.WriteLine("You grasp the child's hands ");
                    Console.WriteLine("And suddenly realize that your positions have been reversed  ");
                }
                else
                {

                } 

            }
            //INCOMPLETE ELSE PATH
            else
            {
                Console.WriteLine("You beging to walk backwards and two pale hands reach from within the a grabs hold of your ankles ");
            } 

        }
    }
}
