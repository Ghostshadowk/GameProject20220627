using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformShoot
{
    public class CameraCtrl : MonoBehaviour
    {
        private Transform mTarget;

        private void Start()
        {
            mTarget = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void LateUpdate()//逻辑更新全部结束之后更新摄像机
        {
            transform.localPosition = new Vector3(mTarget.position.x, mTarget.position.y, transform.localPosition.z);
        }
    }

}
