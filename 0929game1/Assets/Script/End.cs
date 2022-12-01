using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    public class End : MonoBehaviour
    {
        public static End instance;
        private CanvasGroup groupFinal;
        private TextMeshProUGUI textMeshProUGUI;
        private Button button;

        private void Awake()
        {
            instance=this;
            groupFinal = GameObject.Find("Canvas").GetComponent<CanvasGroup>();
            textMeshProUGUI = GameObject.Find("Title").GetComponent<TextMeshProUGUI>();
            button = GameObject.Find("AgainButtom").GetComponent<Button>();
        }

        public void GameOver()
        {
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }    

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;

        }
    }
}