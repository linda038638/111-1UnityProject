using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// KID老師的unity寫法與教學
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