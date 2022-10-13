using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

#region 註解用法與介紹

//單行註解
/*多行註解
 * 每enter一次
 * 就多一個星號
 * 記得在最後一行加入斜線
 */

#endregion

namespace FirstGame
{
    public class FirstScript : MonoBehaviour
    {
        //遊戲預備
        private void Awake()
        {
            //練習output
            //文字樣式可用Rich Text編寫
            print(0);
            Debug.Log("<b>哈</b><color=yellow>囉</color>");
        }

        //遊戲開啟
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
