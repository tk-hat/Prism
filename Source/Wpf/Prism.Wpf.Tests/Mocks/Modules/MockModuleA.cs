using Prism.Ioc;
using Prism.Modularity;
using System;

namespace Prism.Wpf.Tests.Mocks.Modules
{
    public class MockModuleA : IModule
    {
        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void OnInitialized()
        {
            throw new NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }
    }

    public class DummyClass
    {
    }
}
