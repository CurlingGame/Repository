using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{

    public GameObject HouseCam; 
    public GameObject FrontCam;
    public GameObject HouseCamButton;
    public GameObject FrontCamButton;
    public GameObject InGameUI;
    public GameObject AudioSetting;
    public GameObject GameSetting;



    public void OnClickHouseCam()
    {   
        FrontCam.SetActive(false);
        HouseCam.SetActive(true);
        HouseCamButton.SetActive(false);
        FrontCamButton.SetActive(true);
        


    }

    public void OnClickFrontCam()
    {
        FrontCam.SetActive(true);
        HouseCam.SetActive(false);
        HouseCamButton.SetActive(true);
        FrontCamButton.SetActive(false);
        
    }

    public void OnClickStart()
    {   //��ŸƮ ��ư�� ������ ������ ���콺 ���� �۵����� �ʾƾ���.
        InGameUI.SetActive(false);
    }




    public void OnClickGameSetting()
    {
        GameSetting.SetActive(true);
    }

    public void OnClickExitGameSetting()
    {
        GameSetting.SetActive(false);
    }





    public void OnClickAudioSetting()
    {
        AudioSetting.SetActive(true);
    }


    public void OnClickExitAudioSetting()
    {
        AudioSetting.SetActive(false);
        GameSetting.SetActive(false);
    }




    public void OnClickGameQuit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }













}
