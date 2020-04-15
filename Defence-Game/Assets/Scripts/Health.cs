using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Slider slider;

   // public Slider Slider { get => slider; set => slider = value; }

    public void SetMaxHP(float hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void SetHealth(float hp)
    {
        slider.value = hp;
    }
}
