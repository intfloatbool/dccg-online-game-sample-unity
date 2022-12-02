using Services.GlobalsProvider;
using Services.GlobalsProvider.Concrete;
using Services.UI;
using Services.UI.Concrete;
using UIElements.Screens;
using UnityEngine;
using Zenject;

namespace Initialization
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindFactories();
            BindServices();
            
            Test();
        }

        private void BindFactories()
        {

        }
        
        private void BindServices()
        {
            Container.Bind<IUIGlobalsProviderService>()
                .FromInstance(FindObjectOfType<FromSceneUIGlobalsProviderService>());

            Container.Bind<IUIService>().To<ResourcedUIService>().AsSingle();
        }

        private void Test()
        {
            Container.Resolve<IUIService>().OpenScreen<LoadingScreenUIElement>();
        }
    }
}