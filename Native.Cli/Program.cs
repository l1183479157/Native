﻿using DotNetCli;
using Ink;
using NStandard;
using System;
using System.Reflection;

namespace PISharp.Cli
{
    public class Program
    {
        public static readonly string CLI_VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static CommandContainer CommandContainer;
        public static ProjectInfo ProjectInfo => CommandContainer.ProjectInfo;

        static void Main(string[] args)
        {
            CommandContainer = new CommandContainer("pi", ProjectInfo.GetCurrent());
            CommandContainer.CacheCommands(Assembly.GetExecutingAssembly());

            PrintWelcome();

            CommandContainer.PrintProjectInfo();
            CommandContainer.Run(args);
        }

        public static void PrintWelcome()
        {
            Console.WriteLine($@"
{"ヽ(*^▽^)ノ".Center(60)}

PInvoke .NET Command-line Tools {CLI_VERSION}");
        }

    }
}
