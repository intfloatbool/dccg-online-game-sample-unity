using Zenject;

namespace MVVM.Core
{
    public abstract class ModelBase<T> where T : IViewModel
    {
        protected T _viewModel;

        [Inject]
        public virtual void Init(T viewModel)
        {
            _viewModel = viewModel;
        }
    }
}