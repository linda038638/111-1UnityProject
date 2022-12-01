using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
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