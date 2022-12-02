using UnityEngine;

namespace Services.GlobalsProvider
{
    public interface IUIGlobalsProviderService
    {
        Canvas StaticUiCanvas { get; }
        Canvas DynamicUiCanvas { get; }
    }
}