using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Services.GameResources.Concrete.LocalAssets
{
    public class LocalAssetsGameResourcesService : IGameResourcesService
    {
        public T LoadResource<T>() where T : Component
        {
            var requiredType = typeof(T);

            var loadedAsset = Resources.Load(requiredType.Name) as T;

            if (!loadedAsset)
            {
                Debug.LogError($"[{GetType().Name}] resource with name '{requiredType.Name}' has not found!!!");
            }
            
            return loadedAsset;
        }

        public async UniTask<T> LoadResourceAsync<T>() where T : Component
        {
            var requiredType = typeof(T);

            var loadedAsset = await Resources.LoadAsync(requiredType.Name) as T;

            if (!loadedAsset)
            {
                Debug.LogError($"[{GetType().Name}] resource with name '{requiredType.Name}' has not found!!!");
            }
            
            return loadedAsset;
        }
        
    }
}