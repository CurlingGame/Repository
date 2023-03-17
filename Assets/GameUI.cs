using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameObject InGameUIPanel;
    public GameObject InGameSettingPanel;
    public GameObject HouseCam; 
    public GameObject FrontCam;
    public GameObject HouseCamButton;
    public GameObject FrontCamButton;


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
        InGameUIPanel.SetActive(false);
    }

    public void OnClickInGametoSetting()
    {
        InGameSettingPanel.SetActive(true);
        InGameUIPanel.SetActive(false);

    }

    public void OnClickSettingtoInGame()
    {
        InGameSettingPanel.SetActive(false);
        InGameUIPanel.SetActive(true);

    }










}
