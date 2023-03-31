using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{ 
    public GameObject MainPanel;
    public GameObject RulePanel1;
    public GameObject RulePanel2;
    public GameObject RulePanel3;
    public GameObject RulePanel4;
    public GameObject RulePanel5;
    public GameObject SettingPanel;
    public GameObject FrontCam;
    public GameObject UICanvas;
    public GameObject GameXButton;
    public GameObject MenuXButton;
    public GameObject InGameSetting;
    public GameObject GameExitButton;
    public GameObject MenuExitButton;





    public void OnClickGameStart()
    {

        FrontCam.SetActive(true);
        MainPanel.SetActive(false);
        UICanvas.SetActive(true);
        

    }
    public void OnClickGameRule()
    {
        MainPanel.SetActive(false);
        RulePanel1.SetActive(true);
        GameExitButton.SetActive(false);
        MenuExitButton.SetActive(true);
    }




    public void OnClickGameQuit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void OnClick1page()
    {
        RulePanel1.SetActive(true);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(false);
        
    }

    public void OnClick2page()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(true);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(false);
    }

    public void OnClick3Page()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(true);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(false);
    }

    public void OnClick4Page()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(true);
        RulePanel5.SetActive(false);
    }

    public void OnClick5page()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(true);
    }

    public void OnClicksettingtomenu()
    {
        SettingPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void OnClickRuletomenu()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void OnClickINGameSettingChoice()
    {
        InGameSetting.SetActive(true);
        UICanvas.SetActive(false);
        

    }


    public void OnClickGameSetting()
    {
        MainPanel.SetActive(false);
        SettingPanel.SetActive(true);
        GameXButton.SetActive(false);
        MenuXButton.SetActive(true);
        
    }
    
    public void OnClickINGameSetting()
    {

        SettingPanel.SetActive(true);
        GameXButton.SetActive(true);
        MenuXButton.SetActive(false);
        InGameSetting.SetActive(false);

    }
    public void OnClickGameXButton()
    {
        SettingPanel.SetActive(false);
        UICanvas.SetActive(true);

    }
    public void OnClickINGameRule()
    {
        RulePanel1.SetActive(true);
        GameExitButton.SetActive(true);
        MenuExitButton.SetActive(false);
        InGameSetting.SetActive(false);

    }

    public void OnClickGameExitButton()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(false);
        UICanvas.SetActive(true);

    }












}
