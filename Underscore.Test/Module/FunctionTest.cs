﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Module
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void FunctionModuleCreateTest( )
        {
            var testing = new global::Underscore.Module.Function(
                 new BindingComponent( ),
                 new PartialComponent( ),
                 new SplitComponent( ),
                 new ComposeComponent( ),
                 new ConvertComponent(),
                 new SynchComponent(),
                 new CacheComponent()
            );
        }
    }
}