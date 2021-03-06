﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator attack;
    [SerializeField] int clickCounter = 0;
    //[SerializeField] float maxHealth = 100.0f;
    //[SerializeField] Health health;
    //private float currentHP;
    private bool canClick = true;


    // Start is called before the first frame update
    void Start()
    {
        attack.GetComponent<Animator>();
        //currentHP = maxHealth;
       // health.SetMaxHP(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Attack"))
        {
            AttackCombo();
        }
 
    }

    //public void Rolling()
    //{
    //    if (Input.GetButtonDown("Jump"))
    //    {
    //        attack.SetBool("Roll", true);
    //    }
    //    if (Input.GetButtonUp("Jump")){
    //        attack.SetBool("Roll", false);
    //    }
    //}


    //void TakeDamage(float damage)
    //{
    //    currentHP -= damage;
    //    health.SetHealth(currentHP);
    //}

     //This will keep track of the click the player does
    void AttackCombo()
    {
        if (canClick)
        {
            clickCounter++;
        }
        if(clickCounter == 1)
        {
            attack.SetBool("FirstAttack", true);
        }
        //Max number of click
        clickCounter = Mathf.Clamp(clickCounter, 0, 3);
    }

    //After one click
    public void AttackOne()
    {
        canClick = false;
        if(clickCounter >= 2)
        {
            attack.SetBool("SecondAttack", true);
            canClick = true;
        }
        else
        {
            attack.SetBool("FirstAttack", false);
            clickCounter = 0;
            canClick = true;
        }
    }

    //Second click
    public void AttackTwo()
    {
        //If click 3 go third, else reset.
        if (clickCounter >= 3)
        {
            attack.SetBool("ThirdAttack", true);
        }
        else
        {
            attack.SetBool("SecondAttack", false);
            clickCounter = 0;
            canClick = true;
        }
    }

    //third click to return to idle animation
    public void AttackThree()
    {
        attack.SetBool("FirstAttack", false);
        attack.SetBool("SecondAttack", false);
        attack.SetBool("ThirdAttack", false);
        clickCounter = 0;
        canClick = true;
    }
}
