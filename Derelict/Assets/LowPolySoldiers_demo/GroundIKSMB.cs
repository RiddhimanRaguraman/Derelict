using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundIKSMB : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }/*
        else if (Input.GetKey(KeyCode.up))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.Down))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.Right))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.Left))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }*/
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);
        }
    }
}
