using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class EnemyRolling : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;


        private void Update()
        {
            transform.Translate(speed * 0.5f * Time.deltaTime, 0, 0);
        }


    }

}
