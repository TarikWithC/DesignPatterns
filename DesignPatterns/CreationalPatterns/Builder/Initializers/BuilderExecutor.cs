﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using DesignPatterns.Base;
using DesignPatterns.CreationalPatterns.Prototype.Game.Initializers;

namespace DesignPatterns.CreationalPatterns.Builder.Initializers
{
    public class BuilderExecutor : BaseExecutor, IPatternExecutor
    {
        #region Class/Object Information
        private const string PatternName = "Builder";
        public string GetPatternName()
        {
            return PatternName;
        }
        #endregion Class/Object Information

        private readonly BuilderTester _builderTester = new();
        public void Execute()
        {
            GenericExecutor.ExecuteStandardTest(tester: _builderTester, patternName: PatternName);
        }

        
    }
}
