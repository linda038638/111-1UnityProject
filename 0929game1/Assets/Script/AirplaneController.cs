using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 


namespace FirstGame
{
    public class AirplaneController : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float H_Speed = 4f;
        [SerializeField, Range(0, 10)]
        private float V_Speed = 3.5f;

        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite Pic_up, Pic_middle, Pic_Down;
        [SerializeField]
        private SpriteRenderer spr;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            
            transform.Translate(
                H_Speed * Time.deltaTime * h,
                V_Speed * Time.deltaTime * v, 
                0);
            
           if(v>0.0f)
            {
                spr.sprite = Pic_up;
            }
            if(v==0.0f)
            {
                spr.sprite = Pic_middle;
            }
            if(v<0.0f)
            {
                spr.sprite = Pic_Down;
            }
        
        
        
        }
    }

}
