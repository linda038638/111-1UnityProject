using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class bgRolling : MonoBehaviour
    {
        [SerializeField,Header("移動速度"),Range(-10,0)]
        private float speed = -3.5f;

       
            private void Update()
        {
            transform.Translate(speed*0.2f*Time.deltaTime,0,0);
        }
        

    }

}
