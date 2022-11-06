using UnityEngine;

namespace Com.Myth.SlashBuild
{
    public class CharacterMotor : MonoBehaviour
    {
        public void Move(Vector2 direction)
        {
            transform.Translate(new Vector3(direction.x, direction.y));
        }
    }
}