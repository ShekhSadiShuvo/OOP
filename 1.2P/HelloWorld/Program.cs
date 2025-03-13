namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message myMessage;
            myMessage = new Message("Hello, World! Greetings from Message Object");
            myMessage.Print();
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
            Message[] messages = new Message[5];
            messages[0] = new Message("Welcome back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("Welcome, nice to me you.");


            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();


            if (name.ToLower() == "asad")
            {
                messages[0].Print();
            }
            else if (name.ToLower() == "shekh")
            {
                messages[1].Print();
            }
            else if (name.ToLower() == "sadi")
            {
                messages[2].Print();
            }
            else if (name.ToLower() == "shuvo")
            {
                messages[3].Print();
            }
            else
            {
                messages[4].Print();
            }
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
