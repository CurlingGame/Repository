using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DontDestroyOnLoadEx : MonoBehaviour
{
    private static DontDestroyOnLoadEx instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // ���� ������Ʈ�� �ı����� �ʰ� ����
        }
        else
        {
            Destroy(gameObject); // �ߺ��Ǵ� ���� ������Ʈ�� ������� ���� ������Ʈ �ı�
        }
    }
}