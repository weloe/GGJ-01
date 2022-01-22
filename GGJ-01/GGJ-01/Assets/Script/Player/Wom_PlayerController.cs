using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GGJ.PlayerControlller
{
    public class Wom_PlayerController : MonoBehaviour
    {
        public float HorizontalSpeed;
        public float VerticalSpeed;
        private float x_move;
        private float y_move;
        public float facedirection;
        public Rigidbody2D m_rig;
        public Collider2D coll;
        public Animator anim;


        private void Start()
        {
            m_rig = GetComponent<Rigidbody2D>();
            coll = GetComponent<Collider2D>();
            anim = GetComponent<Animator>();
        }

        void FixedUpdate()
        {
            Movement();
        }

        void Movement()
        {
            x_move = Input.GetAxisRaw("Horizontal_P1");
            y_move = Input.GetAxisRaw("Vertical_P1");
            m_rig.velocity = new Vector2(x_move * HorizontalSpeed*Time.deltaTime, y_move * VerticalSpeed*Time.deltaTime);
            if (m_rig.velocity != Vector2.zero)
            {
                anim.SetBool("isMove", true);
            }
            else
            {
                anim.SetBool("isMove", false);
            }
        }
    }

}
