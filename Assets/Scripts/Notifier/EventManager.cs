using System;

namespace Notifier
{
    public static class EventManager
    {
        // The event where the other components subscribe
        // their methods to achieve the jump off the player.
        public static event Action OnPlayerJump;

        public static void Jump()
        {
            OnPlayerJump?.Invoke();
        }
    }
}