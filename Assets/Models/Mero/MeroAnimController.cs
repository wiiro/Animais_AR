﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeroAnimController : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeMero_IdleBake"))
            {
                anim.Play("PeixeMero_TouchBake");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeMero_TouchBake"))
            {
                anim.Play("PeixeMero_IdleBake");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeMero_IdleBake"))
        {
            anim.Play("PeixeMero_TouchBake");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeMero_TouchBake"))
        {
            anim.Play("PeixeMero_IdleBake");
        }
    }
}
