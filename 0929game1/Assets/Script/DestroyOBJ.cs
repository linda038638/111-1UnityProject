using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    public class DestroyOBJ : FireSystemBase
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
