using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    public class switchSenes : MonoBehaviour
    {
        public void SwitchScenesToGame()
        {
            print("do");
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}