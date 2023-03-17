using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameObject InGameUIPanel;
    public GameObject InGameSettingPanel;
    public GameObject HouseCam; //카메라 전환 버튼을 눌렀을때 하우스의 상황을 보여줄 카메라


    public void OnClickCamChange()
    {   //카메라 전환 버튼을 눌렀을때 하우스를 보고 있는 카메라로 카메라 전환

    }

    public void OnClickStart()
    {   //스타트 버튼을 누르기 전에는 마우스 휠이 작동되지 않아야함.
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
