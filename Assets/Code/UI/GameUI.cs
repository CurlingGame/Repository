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
    public GameObject Scoreboard;
    public GameObject ScoreboardButton;
    public GameObject ScoreboardExitButton;

    public GameObject RedTeamWin;
    public GameObject BlueTeamWin;
    public GameObject RedBlueDraw;


    

    public void RedWin()
    {
        RedTeamWin.SetActive(true);
    }
    public void BlueWin()
    {
        BlueTeamWin.SetActive(true);

    }
    public void Draw()
    {
        RedBlueDraw.SetActive(true);
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }


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

    public void OnClickScoreboard()
    {   
        Scoreboard.SetActive(true);
        ScoreboardButton.SetActive(false);
        ScoreboardExitButton.SetActive(true);
    }

    public void OnClickExitScoreboard()
    {
        Scoreboard.SetActive(false);
        ScoreboardExitButton.SetActive(false);
        ScoreboardButton.SetActive(true);
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
