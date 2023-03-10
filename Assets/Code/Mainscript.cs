using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour
{
    public GameObject Rstone;

    void Start()
    {
        Debug.Log("start");
        Rstone.SendMessage("Ready");
    }

    void Update()
    {
        Rstone.SendMessage("Throw");
    }
}
