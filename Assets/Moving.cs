using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

        public Transform target;        // ����ٴ� Ÿ�� ������Ʈ�� Transform

        private Transform tr;                // ī�޶� �ڽ��� Transform

        void Start()
        {
            tr = GetComponent<Transform>();
        }

        void Update()
        {
            tr.position = new Vector3(target.position.x , tr.position.y, target.position.z);

            tr.LookAt(target);
        }
    }