using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour
{
    float power = 2.0f;
    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 pos;
        pos = transform.position; // ���� ������Ʈ ��ġ
        if (pos.x < -11.0f)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("��");
                if ((-18.0f < pos.x) && (power == 2.0f))
                {
                    power = power + 3.0f;
                    Debug.Log("�١١�");
                }
                if ((-13.0f < pos.x) && (power == 5.0f))
                {
                    power = power + 5.0f;
                    Debug.Log("�١١١١�");
                }
                rb.AddForce(Vector3.right * power);
            }
        }
    }
}
