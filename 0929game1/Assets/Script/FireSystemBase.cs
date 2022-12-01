using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class FireSystemBase : MonoBehaviour
    {

        [SerializeField, Header("spawnPrefab")]
        private GameObject prefab;
        [SerializeField, Header("spawnBullet")]
        private Transform pointSpawn;

        protected void spawnBullet()
        {
            Instantiate(prefab, pointSpawn.position, pointSpawn.rotation);
        }



    }

}
