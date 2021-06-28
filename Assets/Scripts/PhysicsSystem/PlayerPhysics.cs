using Notifier;
using UnityEngine;

namespace PhysicsSystem
{
    public sealed class PlayerPhysics : MonoBehaviour
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
            Debug.Log("Physics Jump");
        }
    }
}