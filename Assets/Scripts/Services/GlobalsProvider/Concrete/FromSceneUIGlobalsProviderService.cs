using UnityEngine;

namespace Services.GlobalsProvider.Concrete
{
    public sealed class FromSceneUIGlobalsProviderService : MonoBehaviour, IUIGlobalsProviderService
    {
        [SerializeField] private Canvas _staticUiCanvas;
        [SerializeField] private Canvas _dynamicUiCanvas;

        public Canvas StaticUiCanvas => _staticUiCanvas;
        public Canvas DynamicUiCanvas => _dynamicUiCanvas;
    }
}