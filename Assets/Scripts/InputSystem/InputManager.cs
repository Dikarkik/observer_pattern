using Notifier;
using UnityEngine;

namespace InputSystem
{
    public sealed class InputManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EventManager.Jump();
            }
        }
    }
}