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
            DontDestroyOnLoad(gameObject); // 게임 오브젝트가 파괴되지 않게 유지
        }
        else
        {
            Destroy(gameObject); // 중복되는 게임 오브젝트가 있을경우 게임 오브젝트 파괴
        }
    }
}