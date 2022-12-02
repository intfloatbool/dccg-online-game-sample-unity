using System.Collections.Generic;
using System.ComponentModel;
using Services.GlobalsProvider;
using Zenject;

namespace Services.UI.Concrete
{
    public class ResourcedUIService : IUIService, ITickable
    {
        protected IUIGlobalsProviderService _uiGlobalsProviderService;
        
        
        protected Stack<UIElementBase> _dialogsStack = new Stack<UIElementBase>();
        protected DiContainer _container;
        

        [Inject]
        public void Init(IUIGlobalsProviderService iuiGlobalsProviderService, DiContainer container)
        {
            _container = container;
            _uiGlobalsProviderService = iuiGlobalsProviderService;
        } 
        
        public virtual T OpenScreen<T>() where T : UIElementBase
        {
            var typeName = typeof(T).Name;
            
            //TODO: take it from pool
            var element = 
                    _container.InstantiatePrefabResource(
                        typeName, _uiGlobalsProviderService.StaticUiCanvas.transform
                        ).GetComponent<T>();
            
            return element;
        }
        
        public void Close(UIElementBase element)
        {
            element.SetActive(false);
        }
        

        public T OpenDialogue<T>() where T : UIElementBase
        {
            throw new System.NotImplementedException();
            IPoolable x;
        }

        


        public virtual void Tick()
        {
            throw new System.NotImplementedException();
        }
    }
}