using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class DestroyOBJ2 : MonoBehaviour
    {



        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }



    }

}
