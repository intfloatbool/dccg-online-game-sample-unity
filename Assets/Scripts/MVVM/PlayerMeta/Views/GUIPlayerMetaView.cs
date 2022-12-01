using MVVM.Core;
using MVVM.PlayerMeta.ViewModels;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace MVVM.PlayerMeta.Views
{
    public class GUIPlayerMetaView : ViewBase<IPlayerMetaViewModel>
    {
        [SerializeField] protected TextMeshProUGUI _nicknameText;
        [SerializeField] protected TextMeshProUGUI _softCurrencyText;
        [SerializeField] protected TextMeshProUGUI _hardCurrencyText;

        private void OnValidate()
        {
            Assert.IsNotNull(_nicknameText, "_nicknameText != null");
            Assert.IsNotNull(_softCurrencyText, "_softCurrencyText != null");
            Assert.IsNotNull(_hardCurrencyText, "_hardCurrencyText != null");
        }

        public override void Init(IPlayerMetaViewModel viewModel)
        {
            base.Init(viewModel);
            
            SetNickname(viewModel.NickName.Value);
            SetSoftValue(viewModel.SoftCurrencyAmount.Value);
            SetHardValue(viewModel.HardCurrencyAmount.Value);
            
            viewModel.NickName.Subscribe(SetNickname);
            viewModel.SoftCurrencyAmount.Subscribe(SetSoftValue);
            viewModel.HardCurrencyAmount.Subscribe(SetHardValue);
        }
        
        private void SetNickname(string nickname)
        {
            _nicknameText.SetText(nickname);
        }

        private void SetSoftValue(int softValue)
        {
            _softCurrencyText.SetText(softValue.ToString());
        }
            
        private void SetHardValue(int hardValue)
        {
            _hardCurrencyText.SetText(hardValue.ToString());
        }
    }
}