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

        private bool isMoveEnable = false;

        public Mover()
        {
            Car.OnCarStartMovement += EnableMovement;
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
            if (isMoveEnable)
            {
                moveActions[CheckMovementEnable()]?.Invoke();
                Move();
            };
        }

        private string CheckMovementEnable()
        {
            string s = Console.ReadLine();

            if (s == "x")
            {
                DisableMovement();
            }

            return s;
        }

        private void DisableMovement() => isMoveEnable = false;
 
        private void EnableMovement() => isMoveEnable = true;

    }
}
