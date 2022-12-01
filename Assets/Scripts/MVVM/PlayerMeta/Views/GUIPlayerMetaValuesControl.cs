using MVVM.Core;
using MVVM.PlayerMeta.ViewModels;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace MVVM.PlayerMeta.Views
{
    public class GUIPlayerMetaValuesControl : ViewBase<IPlayerMetaViewModel>
    {
        [SerializeField] private TMP_InputField _nicknameInput;
        [SerializeField] private TMP_InputField _softInput;
        [SerializeField] private TMP_InputField _hardInput;

        private void OnValidate()
        {
            Assert.IsNotNull(_nicknameInput, "_nicknameInput != null");
            Assert.IsNotNull(_softInput, "_softInput != null");
            Assert.IsNotNull(_hardInput, "_hardInput != null");
        }
        
        public override void Init(IPlayerMetaViewModel viewModel)
        {
            base.Init(viewModel);

            _nicknameInput.text = viewModel.NickName.Value;
            _softInput.text = viewModel.SoftCurrencyAmount.Value.ToString();
            _hardInput.text = viewModel.HardCurrencyAmount.Value.ToString();
            
            _nicknameInput.onValueChanged.AsObservable().Subscribe((newValue) =>
            {
                viewModel.NickName.SetValueAndForceNotify(newValue);
            });
            
            _softInput.onValueChanged.AsObservable().Subscribe((newValueStr) =>
            {
                if(!int.TryParse(newValueStr, out int newValue))
                    return;
                viewModel.SoftCurrencyAmount.SetValueAndForceNotify(newValue);
            });
            
            _hardInput.onValueChanged.AsObservable().Subscribe((newValueStr) =>
            {
                if(!int.TryParse(newValueStr, out int newValue))
                    return;
                
                viewModel.HardCurrencyAmount.SetValueAndForceNotify(newValue);
            });

        }
    }
}