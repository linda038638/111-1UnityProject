using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                spawnBullet();
            }
        }

    }

}
