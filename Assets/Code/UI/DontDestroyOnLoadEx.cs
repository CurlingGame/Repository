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
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}