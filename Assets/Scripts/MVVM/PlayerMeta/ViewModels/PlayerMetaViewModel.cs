using System.Collections.Generic;
using UniRx;

namespace MVVM.PlayerMeta.ViewModels
{
    public class PlayerMetaViewModel : IPlayerMetaViewModel
    {
        public ReactiveProperty<string> NickName { get; }
        public ReactiveProperty<int> SoftCurrencyAmount { get; }
        public ReactiveProperty<int> HardCurrencyAmount { get; }
        public ReactiveProperty<List<string>> CardIds { get; }

        PlayerMetaViewModel()
        {
            NickName = new ReactiveProperty<string>("?NO_NAME?");
            SoftCurrencyAmount = new ReactiveProperty<int>(-1);
            HardCurrencyAmount = new ReactiveProperty<int>(-1);
        }
    }
}