using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
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