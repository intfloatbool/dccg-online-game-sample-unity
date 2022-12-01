using System.Collections.Generic;
using MVVM.Core;
using UniRx;

namespace MVVM.PlayerMeta.ViewModels
{
    public interface IPlayerMetaViewModel : IViewModel
    {
        public ReactiveProperty<string> NickName { get; }
        public ReactiveProperty<int> SoftCurrencyAmount { get; }
        public ReactiveProperty<int> HardCurrencyAmount { get;  }
        public ReactiveProperty<List<string>> CardIds { get;  }
    }

}