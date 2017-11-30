using Prism.Ioc;
using Prism.Modularity;
using System;

namespace Prism.Wpf.Tests.Mocks.Modules
{
    [Module(ModuleName = "TestModule", OnDemand = true)]
    public class MockAttributedModule : IModule
    {
        public void Initialize()
        {
            throw new NotImplementedException();
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
}
