using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.Myth.SlashBuild
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(CharacterMotor))]
    public class CharacterController : MonoBehaviour
    {
        public float movementSpeed;

        private Animator animator;
        private CharacterMotor motor;
        private SpriteRenderer spriteRenderer;

        private Vector2 m_MoveDirection;

        public void Start()
        {
            animator = GetComponent<Animator>();
            motor = GetComponent<CharacterMotor>();
            spriteRenderer = GetComponent<SpriteRenderer>();
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
            if (m_MoveDirection != Vector2.zero)
            {
                motor.Move(m_MoveDirection * movementSpeed * Time.deltaTime);
                animator.SetBool("Walking", true);
            }
            else
            {
                animator.SetBool("Walking", false);
            }

            if (m_MoveDirection.x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
    }
}