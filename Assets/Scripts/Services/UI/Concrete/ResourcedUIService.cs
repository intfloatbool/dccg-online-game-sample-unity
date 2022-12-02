using System.Collections.Generic;
using System.Linq;
using Services.GameResources;
using Services.GlobalsProvider;
using UnityEngine;
using Zenject;

namespace Services.UI.Concrete
{
    public class ResourcedUIService : IUIService
    {
        protected List<UIElementBase> _openedElements = new List<UIElementBase>(10);

        protected IGameResourcesService _gameResourceService;
        protected IGlobalReferencesProviderService _globalReferencesProviderService;

        [Inject]
        public void Init(IGameResourcesService gameResourcesService, IGlobalReferencesProviderService globalReferencesProviderService)
        {
            _gameResourceService = gameResourcesService;
            _globalReferencesProviderService = globalReferencesProviderService;
        } 
        
        public virtual T OpenElement<T>(EUIShowType showType) where T : UIElementBase
        {
            var elementPrefab = _gameResourceService.LoadResource<T>();
            var elementInstance = Object.Instantiate(elementPrefab, _globalReferencesProviderService.StaticUiCanvas.transform);
            _openedElements.Add(elementInstance);
            return elementInstance;
        }

        public virtual void CloseElement<T>() where T : UIElementBase
        {
            var openedElement = _openedElements.FirstOrDefault(e => e.GetType().Name.Equals(typeof(T).Name));
            if (openedElement)
            {
                _openedElements.Remove(openedElement);
                Object.Destroy(openedElement);   
            }
        }
    }
}