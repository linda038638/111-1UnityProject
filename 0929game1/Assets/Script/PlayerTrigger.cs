using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    public class PlayerTrigger  : MonoBehaviour
    {
        private void OnDestroy()
        {
           End.instance.GameOver();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
           End.instance.GameOver();
        }
        

    }
}