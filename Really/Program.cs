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
                    Console.WriteLine("You are now in a pit . . .  ");
                    Console.WriteLine("The sand closes in around your fingers . . .");
                    Console.WriteLine("And just as you feel you are about to be engulfed in sand");
                    Console.WriteLine("A gnarled hand stretches its fingers towards you. . . ");

                    //I WANTED TO BE ABLE TO USE A "do while loop"                   
                    string handGrasp;
                    do
                    {
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You can only scream, fight, or relent. Which do you choose?");
                        Console.WriteLine("Scream");
                        Console.WriteLine("Fight");
                        Console.WriteLine("Relent");



                        Console.WriteLine("Which do you choose?");
                        handGrasp = Console.ReadLine();

                        if (handGrasp.ToLower() == "scream")
                        {
                            Console.WriteLine("Your mouth begins to fill with sand  . . . ");
                            Console.WriteLine("You reasses your options");
                        }
                        else if (handGrasp.ToLower() == "fight")
                        {
                            Console.WriteLine("The fingers recoil, but you feel the energy slipping from your body . . .\nresistance is futile . . .");
                            Console.WriteLine("There must be a better option");
                        }
                        else if (handGrasp.ToLower() == "relent")
                        {
                            Console.WriteLine("You reach out towards the hand and it grasps you . . .  ");
                            Console.WriteLine("just as your were slipping out of consciousness. ");
                            Console.WriteLine("You awaken from your stupor to find yourself\nlying near a river\nyour an adolescent");
                        }
                        else
                        {
                            Console.WriteLine("(please make a valid response)");
                        }

                    } while (handGrasp != "relent");

                    Console.WriteLine("a");
                    Console.WriteLine("b");
                    Console.WriteLine("c");











                }
                else
                {
                    //Cowardice path 
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
