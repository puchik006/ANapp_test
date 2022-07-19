using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class Mover : IMovable
    {
        public static Action OnMoveBackward;
        public static Action OnMoveForward;
        public static Action OnMoveLeft;
        public static Action OnMoveRight;
        public static Action OnExitMovement;

        private bool isMoveEnable = true;

        public Mover()
        {
            OnExitMovement += DisableMovement;
        }

        Dictionary<string, Action> moveActions = new Dictionary<string, Action>()
        {
            {"s", OnMoveBackward},
            {"w", OnMoveForward},
            {"a", OnMoveLeft},
            {"d", OnMoveRight},
            {"x", OnExitMovement}
        };

        public void Move()
        {
            moveActions[Console.ReadLine()]?.Invoke();

            if (isMoveEnable)
            {
                Move();
            };
        }

        private void DisableMovement() => isMoveEnable = false;
        private void EnableMovement() => isMoveEnable = true;

    }
}
