using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    public class EnemyFireSystem : FireSystemBase
    {
        private void OnBecameVisible()
        {
             InvokeRepeating("spawnBullet", 0, 1.5f);
        }
      

    }

}
