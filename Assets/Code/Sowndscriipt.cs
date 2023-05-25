using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sowndscriipt : MonoBehaviour
{
    public string targetObjectTag = "Stone";

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag(targetObjectTag))
        { 
            GetComponent<AudioSource>().Play();
        }
    }
}
