using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider slider;           //������ͼ��� �����̴� ����

    public void AudioControl()
    {
        float sound = slider.value;

        if (sound == -40f) masterMixer.SetFloat("BGM", -80); //sound�� -40�� ���, -80���� ����(���� off����)
        else masterMixer.SetFloat("BGM", sound);
    }

    public void AudioControl2()
    {
        float sound = slider.value;

        if (sound == -40f) masterMixer.SetFloat("Sound Effect", -80); //sound�� -40�� ���, -80���� ����(���� off����)
        else masterMixer.SetFloat("Sound Effect", sound);
    }

    public void ToggleAudioVolume()
    {
            AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
    
}
