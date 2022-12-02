using UnityEngine;

namespace Services.GlobalsProvider
{
    public interface IGlobalReferencesProviderService
    {
        Canvas StaticUiCanvas { get; }
        Canvas DynamicUiCanvas { get; }
    }
}