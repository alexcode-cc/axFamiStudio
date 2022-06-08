﻿using System;
using System.Runtime.InteropServices;
using static FamiStudio.Init;
using static GLFWDotNet.GLFW;

namespace FamiStudio
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var cli = new CommandLineInterface(args);
            var commandLine = cli.HasAnythingToDo;

            if (!InitializeBaseSystems(commandLine))
            {
                Environment.Exit(-1);
            }

            if (commandLine)
            {
                cli.Run();
            }
            else
            {
                var fs = new FamiStudio();
                if (!fs.Run(args))
                {
                    Environment.Exit(-1);
                }
            }

            ShutdownBaseSystems();

            // We sometimes gets stuck here on Linux (likely a thread that we dont control still running), lets abort.
            // MATTT : Still true?
            if (Platform.IsLinux)
            {
                Environment.Exit(0);
            }
        }
    }
}
