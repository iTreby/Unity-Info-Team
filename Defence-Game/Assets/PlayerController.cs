﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator attack;

        


    // Start is called before the first frame update
    void Start()
    {
        attack.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            attack.SetBool("IsAttacking", true);
        }
    }
}
