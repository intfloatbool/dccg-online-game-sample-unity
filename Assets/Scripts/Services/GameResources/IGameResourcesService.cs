using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Services.GameResources
{
    public interface IGameResourcesService
    {
        T LoadResource<T>() where T : Component;
        UniTask<T> LoadResourceAsync<T>() where T : Component;
    }
}