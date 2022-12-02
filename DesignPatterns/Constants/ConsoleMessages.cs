﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Constants
{
    public class ConsoleMessages
    {
        public const string? Information  = "Press key to test this pattern.";
        public const string? TestSucceeded = "Test succeeded.";
        public const string? TestFailed = "Test failed.";
        public const string? CommandNotFound = "Command couldn't be found. Please be sure that your input is valid.";
    }
}
