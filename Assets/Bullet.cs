using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformShoot
{
    public class Bullet : MonoBehaviour
    {
        private Transform transForm;
        private float fangxiang;
        // Start is called before the first frame update
        void Start()
        {
            transForm = GameObject.FindGameObjectWithTag("Player").transform;
            fangxiang = transForm.localScale.x;
            GameObject.Destroy(this.gameObject, 3f);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(fangxiang * 12 * Time.deltaTime, 0, 0);//让子弹沿X轴正方向飞行
        }
    }
}