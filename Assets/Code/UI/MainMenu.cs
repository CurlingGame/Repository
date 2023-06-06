using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject SettingPanel;

    public GameObject RulePanel1;
    public GameObject RulePanel2;
    public GameObject RulePanel3;
    public GameObject RulePanel4;
    public GameObject RulePanel5;
    public GameObject RuleExitButton;



    public void OnClickGameStart()
    {
        SceneManager.LoadScene("Ingame Scene");
    }

    public void OnClickGameRule()
    {
        MainPanel.SetActive(false);
        RulePanel1.SetActive(true);
        RuleExitButton.SetActive(true);
    }

    public void OnClickGameSetting()
    {
        MainPanel.SetActive(false);
        SettingPanel.SetActive(true);

    }

    public void OnClickExitSetting()
    {
        SettingPanel.SetActive(false);
        MainPanel.SetActive(true);
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

    public void OnClickExitRule()
    {
        RulePanel1.SetActive(false);
        RulePanel2.SetActive(false);
        RulePanel3.SetActive(false);
        RulePanel4.SetActive(false);
        RulePanel5.SetActive(false);
        MainPanel.SetActive(true);
        RuleExitButton.SetActive(false);

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
