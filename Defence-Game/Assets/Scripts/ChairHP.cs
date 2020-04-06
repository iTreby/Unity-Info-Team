using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairHP : MonoBehaviour
{

    [SerializeField] float maxHealth = 100.0f;
    [SerializeField] Health health;
    private float currentHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(float damage)
    {
        currentHP -= damage;
        health.SetHealth(currentHP);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Soul")
        {
            TakeDamage(5);
        }
    }



     

}
