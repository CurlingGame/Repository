using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameObject InGameUIPanel;
    public GameObject InGameSettingPanel;
  

    public void OnClickCamChange()
    {   //ī�޶� ��ȯ ��ư�� �������� �Ͽ콺�� ���� �ִ� ī�޶�� ī�޶� ��ȯ

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
