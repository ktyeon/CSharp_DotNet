using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax 
                ///<summary>
                /// XML Comments are used to help provide documentation
                /// </summary>
                /// <param name="args">An array of string arguments from the command line</param>        
                /// <returns>
                /// No return value
                /// </returns>
        static void Main(string[] args)
        {
            // Sigle line = comments start with two slashes
            // you can have as many of these as you want
            Console.WriteLine("Hello World!");
            /* Multiple line commets start with a slash adn a star
            annd can continew for several lines
            until a closing star and slash are encountered */
            
        }
    }
}
