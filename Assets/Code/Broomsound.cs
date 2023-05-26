using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broomsound : MonoBehaviour
{
    public void broomsound()
    {
        GetComponent<AudioSource>().Play();
    }
}
