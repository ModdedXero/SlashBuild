using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.Myth.SlashBuild
{
    [RequireComponent(typeof(CharacterMotor))]
    public class CharacterController : MonoBehaviour
    {
        public float movementSpeed;

        private CharacterMotor motor;

        private Vector2 m_MoveDirection;

        public void Start()
        {
            motor = GetComponent<CharacterMotor>();
        }

        public void Update()
        {
            MovePlayer();
        }

        public void OnMove(InputValue value)
        {
            m_MoveDirection = value.Get<Vector2>();
        }

        private void MovePlayer()
        {
            motor.Move(m_MoveDirection * movementSpeed * Time.deltaTime);
        }
    }
}