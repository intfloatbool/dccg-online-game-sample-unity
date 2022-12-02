using UnityEngine;

namespace CommonComponents
{
    public class DoLObject : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}