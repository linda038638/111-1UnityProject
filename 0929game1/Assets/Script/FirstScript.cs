using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

#region ���ѥΪk�P����

//������
/*�h�����
 * �Center�@��
 * �N�h�@�ӬP��
 * �O�o�b�̫�@��[�J�׽u
 */

#endregion

namespace FirstGame
{
    public class FirstScript : MonoBehaviour
    {
        //�C���w��
        private void Awake()
        {
            //�m��output
            //��r�˦��i��Rich Text�s�g
            print(0);
            Debug.Log("<b>��</b><color=yellow>�o</color>");
        }

        //�C���}��
        private void Start()
        {
            print("Start!");
        }
        private void Update()
        {
            print("-");
        }

    }

}
