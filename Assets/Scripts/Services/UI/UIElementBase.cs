using UnityEngine;
using Zenject;

namespace Services.UI
{
    public abstract class UIElementBase : MonoBehaviour
    {
        public bool IsActive => gameObject.activeInHierarchy;
        public void SetActive(bool isActive) => gameObject.SetActive(isActive);

        protected virtual void OnActive() {}
        protected virtual void OnDeactivate() {}

        private void OnEnable()
        {
            OnActive();
        }

        private void OnDisable()
        {
            OnDeactivate();
        }
    }
}