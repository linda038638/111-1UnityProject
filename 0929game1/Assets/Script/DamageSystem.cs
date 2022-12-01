using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("傷害標籤")]
         private string NameTag;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;

      
        private void OnCollisionEnter2D(Collision2D coll)
        {
            print(coll);
            if(coll.gameObject.tag == NameTag)
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

    }

}