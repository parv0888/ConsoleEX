static class ConsoleEx
    {
        public static void WriteInfo( string error )
        {
            ConsoleEx.WriteInfo(error, null);
        }
        public static void WriteInfo( string format, params object[] objs )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(format, objs);
            Console.ResetColor();
        }
        public static void WriteError( string error )
        {
            ConsoleEx.WriteError(error, null);
        }
        public static void WriteError( string format, params object[] objs )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(format, objs);
            Console.ResetColor();
        }
        public static void WriteSuccess( string message )
        {
            ConsoleEx.WriteSuccess(message, null);
        }
        public static void WriteSuccess( string format, params object[] objs )
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(format, objs);
            Console.ResetColor();
        }

        public static ConsoleKeyInfo Wait( string message = null )
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Press Any Key to continue");
            }
            else
            {
                Console.WriteLine(message);
            }

            return Console.ReadKey();
        }
        public static bool Confirm( string message = null )
        {
            if (string.IsNullOrEmpty(message))
            {
                message = "y/n ?";
            }

            Console.WriteLine(message);
            var key = Console.ReadKey();
            if (key.KeyChar == 'y' || key.KeyChar == 'Y') return true;
            else return false;
        }
    }