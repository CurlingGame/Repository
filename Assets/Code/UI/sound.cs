using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider slider;           //오디오믹서와 슬라이더 선언

    public void AudioControl()
    {
        float sound = slider.value;

        if (sound == -30f) masterMixer.SetFloat("BGM", -80); //sound가 -30일 경우, -80으로 설정(사운드 off상태)
        else masterMixer.SetFloat("BGM", sound);
    }

    public void AudioControl2()
    {
        float sound = slider.value;

        if (sound == -25f) masterMixer.SetFloat("Sound Effect", -80); //sound가 -25일 경우, -80으로 설정(사운드 off상태)
        else masterMixer.SetFloat("Sound Effect", sound);
    }

    public void ToggleAudioVolume()
    {
            AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
    
}
