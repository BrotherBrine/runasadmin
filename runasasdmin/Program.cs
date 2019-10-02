using System;
using System.Diagnostics;

namespace runasadmin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string arguments = "";
                if (args.Length == 0)
                {
                    return;
                }
                else
                {
                    foreach (string arg in args)
                    {
                        arguments += $"{arg} ";
                    }
                }
                var process = new Process();
                var startinfo = new ProcessStartInfo($@"{arguments}");
                startinfo.UseShellExecute = true;
                startinfo.CreateNoWindow = true;
                process.StartInfo = startinfo;
                process.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
