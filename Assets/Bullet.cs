using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformShoot
{
    public class Bullet : MonoBehaviour
    {
        private Transform mtransForm;
        private float fangxiang;
        private LayerMask mLayerMask;
        private GameObject mGamePass;
        // Start is called before the first frame update
        void Start()
        {
            mtransForm = GameObject.FindGameObjectWithTag("Player").transform;
            fangxiang = mtransForm.localScale.x;
            GameObject.Destroy(this.gameObject, 3f);
            mLayerMask = LayerMask.GetMask("Ground", "Trigger");
            //mGamePass = GameObject.Find("GamePass").GetComponent<GameObject>();
            var gameObject1 = GameObject.Find("GamePass").GetComponent<GameObject>();
            mGamePass = gameObject1;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(fangxiang * 12 * Time.deltaTime, 0, 0);//让子弹沿X轴正方向飞行
        }
        private void FixedUpdate()
        {
            Collider2D coll = Physics2D.OverlapBox(transform.position, transform.localScale, 0, mLayerMask);
            if (coll)
            {
                if(coll.tag=="Trigger")
                {
                    Destroy(gameObject);
                    mGamePass.SetActive(true);
                }
                Destroy(gameObject);
            }
        }
    }
}