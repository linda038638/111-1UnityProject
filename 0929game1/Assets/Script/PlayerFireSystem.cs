using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
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
