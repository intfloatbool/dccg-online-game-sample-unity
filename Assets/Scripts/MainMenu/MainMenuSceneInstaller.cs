using MVVM.Core;
using MVVM.PlayerMeta;
using MVVM.PlayerMeta.Models;
using MVVM.PlayerMeta.ViewModels;
using Zenject;

namespace MainMenu
{
    public class MainMenuSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlayerMetaViewModel>()
                .To<PlayerMetaViewModel>().AsSingle().NonLazy();
            
            Container.Bind<ModelBase<IPlayerMetaViewModel>>()
                .To<PlayerMetaModelLocalCached>().AsSingle().NonLazy();
        }
    }
}