﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace Hobby.UnitTests.TestingTools
{
    public static class IoCCProvider
    {
        private static Container container = null;

        public static Container Container
        {
            get
            {
                if (container == null)
                {
                    container = Hobby.SimpleInjector.SimpleInjectorConsole.Instance;
                }

                return container;
            }
        }
    }
}
