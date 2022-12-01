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
        [SerializeField, Header("VFX")]
        private AudioClip soundFire;


        protected void spawnBullet()
        {
            Instantiate(prefab, pointSpawn.position, pointSpawn.rotation);

            Sound.instance.PlaySound(soundFire, new Vector2(0.5f, 0.7f));
        }



    }

}
