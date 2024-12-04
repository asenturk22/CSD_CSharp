namespace _026_command_prompt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandPrompt cp = new CommandPrompt("CSD");
            cp.Run();
        }
    }

    class CommandPrompt
    {
        public string prompt;
        public CommandPrompt(string pr)
        {
            prompt = pr;
        }

        public void Run()
        {
            string cmd;

            for (; ; )
            {
                System.Console.Write("{0}>", prompt);
                cmd = System.Console.ReadLine();
                cmd = cmd.Trim();

                if (cmd == "")
                    continue;

                switch(cmd)
                {
                    case "dir":
                        System.Console.WriteLine("dir command");
                        break;
                    case "del":
                        System.Console.WriteLine("del command");
                        break;
                    case "clear":
                        System.Console.WriteLine("clear command");
                        break;
                    case "quit":
                    case "exit":
                        goto EXIT;
                    default:
                        System.Console.WriteLine("Invalid command : '{0}' ", cmd);
                        break;
                }
            }

        EXIT:
            ;
        }
    }
}
