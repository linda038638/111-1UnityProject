using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
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
