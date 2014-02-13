static class ConsoleEx
    {
        public static void Write( string msg )
        {
            Console.WriteLine( msg );
        }
        public static void Write( string format, params object[] objs )
        {
            Console.WriteLine( format, objs );
        }

        public static void WriteInfo( string error )
        {
            ConsoleEx.WriteInfo( error, null );
        }
        public static void WriteInfo( string format, params object[] objs )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( format, objs );
            Console.ResetColor();
        }



        public static void WriteError( string error )
        {
            ConsoleEx.WriteError( error, null );
        }
        public static void WriteError( string format, params object[] objs )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( format, objs );
            Console.ResetColor();
        }
        public static void WriteSuccess( string message )
        {
            ConsoleEx.WriteSuccess( message, null );
        }
        public static void WriteSuccess( string format, params object[] objs )
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine( format, objs );
            Console.ResetColor();
        }

        public static ConsoleKeyInfo Wait( string message = null )
        {
            if (string.IsNullOrWhiteSpace( message ))
            {
                Console.WriteLine( "Press Any Key to continue" );
            }
            else
            {
                Console.WriteLine( message );
            }

            return Console.ReadKey();
        }
        public static bool Confirm( string message = null )
        {
            if (string.IsNullOrEmpty( message ))
            {
                message = "y/n ?";
            }

            Console.WriteLine( message );
            var key = Console.ReadKey();
            if (key.KeyChar == 'y' || key.KeyChar == 'Y') return true;
            else return false;
        }

        public static void BlankLine()
        {
            Console.WriteLine( string.Empty );
        }


        public static T GetOneSelectedByIndex<T>( IEnumerable<T> list )
        {
            BlankLine();
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine( "{0}, {1}", list.ElementAt( i ).ToString(), i );
            }
            Console.WriteLine( "Please enter one index" );
            var index = int.Parse( Console.ReadLine() );

            var c = list.ElementAt( index );

            return c;
        }
    }