using Eventsoef;

delegate void EventHandler(string message);

    internal class Program
    {
        public static void message(string message)
        {
            Console.WriteLine("program reports " + message + ".");
        }
        private static void Main(string[] args)
        {
           
            Stacky<int> stacky = new Stacky<int>();

             stacky.stackChange += new EventHandler(message);

            char keuze = '0';

        do
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Add object to the stack: 1");
            Console.WriteLine("Remove latest object from the stack: 2");
            Console.WriteLine("Clear the stack: 3");
            Console.WriteLine("Show the full stack: 4");
            keuze = Console.ReadLine()[0];
            Console.WriteLine();

            switch (keuze)
            {
                case '0':
                    break;
                case '1':
                    Console.WriteLine("enter the number you want to add to the stack:");
                    stacky.AddObject(Convert.ToInt32(Console.ReadLine()));
                    break;
                case '2':
                    stacky.RemoveObject();
                    break;
                case '3':
                    stacky.Clear();
                    break;
                case '4':
                    stacky.Show();
                    break;
            }
        } while (keuze != '0');
           
        }
    }
