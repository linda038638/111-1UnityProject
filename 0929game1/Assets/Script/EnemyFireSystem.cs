using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
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
