using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    public class bgRolling : MonoBehaviour
    {
        [SerializeField,Header("���ʳt��"),Range(-10,0)]
        private float speed = -3.5f;

       
            private void Update()
        {
            transform.Translate(speed*0.2f*Time.deltaTime,0,0);
        }
        

    }

}
