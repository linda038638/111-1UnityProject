using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class DestroyOBJ : MonoBehaviour
    {   

        private void Awake()
        {
            Destroy(gameObject, 0.5f);

        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }



    }

}
