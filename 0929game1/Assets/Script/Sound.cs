using UnityEngine;
/// <summary>
/// KID老師的unity寫法與教學
/// </summary>
/// 

namespace FirstGame
{
    [RequireComponent(typeof(AudioSource))]
    public class Sound : MonoBehaviour
    {
        public static Sound instance; //定義一個欄位用來保存自己
        private AudioSource aud;
        private void Awake()
        {
            instance = this;
              aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound, Vector2 VolumeR)
        {
            float volume = Random.Range(VolumeR.x, VolumeR.y);
            aud.PlayOneShot(sound, volume);
        }


    }

}
