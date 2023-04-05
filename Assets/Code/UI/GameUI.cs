using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    public GameObject HouseCam; 
    public GameObject FrontCam;
    public GameObject HouseCamButton;
    public GameObject FrontCamButton;
    public GameObject InGameUIPanel;


    public void OnClickHouseCam()
    {   
        FrontCam.SetActive(false);
        HouseCam.SetActive(true);
        HouseCamButton.SetActive(false);
        FrontCamButton.SetActive(true);
        Score_Manager.bscore += 1;
    }

    public void OnClickFrontCam()
    {
        FrontCam.SetActive(true);
        HouseCam.SetActive(false);
        HouseCamButton.SetActive(true);
        FrontCamButton.SetActive(false);
        Score_Manager.rscore += 1;
    }

    public void OnClickStart()
    {   //��ŸƮ ��ư�� ������ ������ ���콺 ���� �۵����� �ʾƾ���.
        InGameUIPanel.SetActive(false);
    }













}
