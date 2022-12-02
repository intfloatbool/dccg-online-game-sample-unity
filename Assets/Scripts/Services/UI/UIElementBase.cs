using UnityEngine;

namespace Services.UI
{
    public abstract class UIElementBase : MonoBehaviour
    {
        public bool IsActive => gameObject.activeInHierarchy;
        public void SetActive(bool isActive) => gameObject.SetActive(isActive);
    }
}