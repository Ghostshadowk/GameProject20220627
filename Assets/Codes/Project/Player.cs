using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace PlatformShoot
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D mRig;
        private float mGroundMoveSpeed = 5f;
        private float mJumpForce = 12f;
        private bool isJump;
        private void Start()
        {
            mRig = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJump = true;
            }
            if(Input.GetKeyDown(KeyCode.J))
            {
                GameObject bullet = Resources.Load<GameObject>("Bullet");//加载资源
                GameObject.Instantiate(bullet, transform.position, Quaternion.identity);//资源加载进场景
            }
        }
        private void FixedUpdate()
        {
            //跳跃
            if(isJump)
            {
                mRig.velocity = new Vector2(mRig.velocity.x, mJumpForce);
                isJump = false;
            }
            //移动
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * mGroundMoveSpeed, mRig.velocity.y);
            if(Input.GetAxisRaw("Horizontal")!=0)
            {
                transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal"), 1, 1);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag=="Door")
            {
                SceneManager.LoadScene("GamePassScene");
            }
        }
    }
}
