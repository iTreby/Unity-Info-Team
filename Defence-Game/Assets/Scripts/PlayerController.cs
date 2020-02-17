using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator attack;
    [SerializeField] int clickCounter = 0;
    [SerializeField] float lastClick = 0;
    [SerializeField] float comboTimeDelay = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        attack.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastClick > comboTimeDelay)
        {
            clickCounter = 0;
            AttackThree();
        }

        if (Input.GetButtonDown("Attack"))
        {
            lastClick = Time.time;
            clickCounter++;
            if (clickCounter == 1)
            {
                attack.SetBool("FirstAttack", true);
            }
            //Max number of click
            clickCounter = Mathf.Clamp(clickCounter, 0, 3);
        }
    }

    void AttackCombo()
    {
        if (Input.GetButtonDown("Attack"))
        {
            lastClick = Time.time;
            clickCounter++;
            if(clickCounter == 1)
            {
                attack.SetBool("FirstAttack", true);
            }
            //Max number of click
            clickCounter = Mathf.Clamp(clickCounter, 0, 3);
        }
    }

    public void AttackOne()
    {
        //If click 2+ go second, else reset.
        if(clickCounter >= 2)
        {
            attack.SetBool("SecondAttack", true);
        }
        else
        {
            attack.SetBool("FirstAttack", false);
            clickCounter = 0;
        }
    }

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
        }
    }

    public void AttackThree()
    {
        attack.SetBool("FirstAttack", false);
        attack.SetBool("SecondAttack", false);
        attack.SetBool("ThirdAttack", false);
        clickCounter = 0;
    }
}
