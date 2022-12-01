using UnityEngine;
/// <summary>
/// KID�Ѯv��unity�g�k�P�о�
/// </summary>
/// 

namespace FirstGame
{
    [RequireComponent(typeof(AudioSource))]
    public class Sound : MonoBehaviour
    {
        public static Sound instance; //�w�q�@�����ΨӫO�s�ۤv
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
