using Notifier;
using UnityEngine;

namespace AudioSystem
{
    public sealed class AudioManager : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnPlayerJump += Jump;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerJump -= Jump;
        }

        private void Jump()
        {
            Debug.Log("Audio Jump");
        }
    }
}