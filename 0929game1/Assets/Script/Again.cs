using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class Again : MonoBehaviour
    {
        public void SwitchScenesToGame()
        {
            print("do");
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}