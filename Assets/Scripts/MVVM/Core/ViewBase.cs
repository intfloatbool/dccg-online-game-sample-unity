using UnityEngine;
using Zenject;

namespace MVVM.Core
{
    public abstract class ViewBase<T> : MonoBehaviour where T : IViewModel
    {
        protected T _viewModel;

        [Inject]
        public virtual void Init(T viewModel)
        {
            _viewModel = viewModel;
        }
    }
}