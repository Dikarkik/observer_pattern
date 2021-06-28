using Notifier;
using UnityEngine;

namespace AnimationSystem
{
    public sealed class PlayerAnimation : MonoBehaviour
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
            Debug.Log("Animation Jump");
        }
    }
}