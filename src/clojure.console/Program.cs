using CommandLine;
using clojure.lang.Hosting;

namespace clojure.console
{
    class Program
    {
        class Options
        {
            [Option("c", "clj", DefaultValue = false)]
            public bool ClojureRepl { get; set; }
        } 

        static private readonly Options options = new Options();

        static void Main(string[] args)
        {
            var cmdParser = new CommandLineParser();
            cmdParser.ParseArguments(args, options);

            //Clojure.AddNamespaceDirectoryMapping("namespace", @"src\namespace");

            //var replInit = "(use 'namespace.init)\n" + 
            //  "(in-ns 'namespace.init)\n" +
            //  "(main)";

            if (options.ClojureRepl)
                Clojure.GetVar("clojure.main", "main").invoke("-r");
                //Clojure.GetVar("clojure.main", "main").invoke("-e", replInit, "-r");
        }
    }
}
