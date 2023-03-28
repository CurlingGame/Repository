using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{ 
    public GameObject MainPanel;
    public GameObject RulePanel;
    public GameObject page2;
    public GameObject SettingPanel;
    public GameObject FrontCam;
    public GameObject UICanvas;
    public GameObject GameXButton;
    public GameObject MenuXButton;




    public void OnClickGameStart()
    {

        FrontCam.SetActive(true);
        MainPanel.SetActive(false);
        UICanvas.SetActive(true);
        

    }
    public void OnClickGameRule()
    {
        MainPanel.SetActive(false);
        RulePanel.SetActive(true);
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

    }
    public void OnClickGameXButton()
    {
        SettingPanel.SetActive(false);
        
    }



    public void OnClickGameQuit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void OnClicknextpage()
    {
        RulePanel.SetActive(false);
        page2.SetActive(true);
    }

    public void OnClickbeforepage()
    {
        RulePanel.SetActive(true);
        page2.SetActive(false);
    }

    public void OnClicksettingtomenu()
    {
        SettingPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void OnClickrule1tomenu()
    {
        RulePanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void OnClickrule2tomenu()
    {
        page2.SetActive(false);
        MainPanel.SetActive(true);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }







}
