using MVVM.Core;
using MVVM.PlayerMeta.ViewModels;
using UniRx;
using UnityEngine;

namespace MVVM.PlayerMeta.Models
{
    public class PlayerMetaModelLocalCached : ModelBase<IPlayerMetaViewModel>
    {
        private readonly string META_NICKNAME_PLAYER_PREFS_KEY = "META_NICKNAME_PLAYER_PREFS";
        private readonly string META_SOFT_PLAYER_PREFS_KEY = "META_SOFT_PLAYER_PREFS";
        private readonly string META_HARD_PLAYER_PREFS_KEY = "META_HARD_PLAYER_PREFS";
        
        public override void Init(IPlayerMetaViewModel viewModel)
        {
            base.Init(viewModel);

            string initialNickname = "Newbie Player";
            int initialSoftCurrency = 100;
            int initialHardCurrency = 50;

            if (PlayerPrefs.HasKey(META_NICKNAME_PLAYER_PREFS_KEY))
                initialNickname = PlayerPrefs.GetString(META_NICKNAME_PLAYER_PREFS_KEY);

            if (PlayerPrefs.HasKey(META_SOFT_PLAYER_PREFS_KEY))
                initialSoftCurrency = PlayerPrefs.GetInt(META_SOFT_PLAYER_PREFS_KEY);
            
            if (PlayerPrefs.HasKey(META_HARD_PLAYER_PREFS_KEY))
                initialHardCurrency = PlayerPrefs.GetInt(META_HARD_PLAYER_PREFS_KEY);
            
            viewModel.NickName.SetValueAndForceNotify(initialNickname);
            viewModel.SoftCurrencyAmount.SetValueAndForceNotify(initialSoftCurrency);
            viewModel.HardCurrencyAmount.SetValueAndForceNotify(initialHardCurrency);

            viewModel.NickName.Subscribe(OnNicknameChanged);
            viewModel.SoftCurrencyAmount.Subscribe(OnSoftValueChanged);
            viewModel.HardCurrencyAmount.Subscribe(OnHardValueChanged);

        }

        private void OnNicknameChanged(string nickname)
        {
            PlayerPrefs.SetString(META_NICKNAME_PLAYER_PREFS_KEY, nickname);
        }
        
        private void OnSoftValueChanged(int softValue)
        {
            PlayerPrefs.SetInt(META_SOFT_PLAYER_PREFS_KEY, softValue);
        }
        
        private void OnHardValueChanged(int hardValue)
        {
            PlayerPrefs.SetInt(META_HARD_PLAYER_PREFS_KEY, hardValue);
        }
    }
}