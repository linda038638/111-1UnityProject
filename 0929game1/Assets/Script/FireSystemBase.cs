using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
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
