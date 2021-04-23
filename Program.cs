using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CompileApp
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				var fileEntries = Directory.GetFiles("filterscripts");
                using var myProcess = new Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                foreach (var file in fileEntries)
                {
                    var fn = Path.GetFileName(file);
                    if (fn.IndexOf(".pwn") != -1)
                    {
                        myProcess.StartInfo.Arguments = "/c cd filterscripts & pawncc " + fn;
                        myProcess.Start();
                    }

                }
            }
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}
		}
    }
}
