using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

        public Transform target;        // 따라다닐 타겟 오브젝트의 Transform

        private Transform tr;                // 카메라 자신의 Transform

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