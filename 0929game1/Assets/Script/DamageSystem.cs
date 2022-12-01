using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�ˮ`����")]
         private string NameTag;
        [SerializeField, Header("�z���w�s��")]
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