using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text timer;
    [SerializeField] GameObject winningState;
    private float timeLeft = 120.0f;

    // Start is called before the first frame update
    void Start()
    {
        winningState.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = "TIME : " + (int)timeLeft;
        if(timeLeft < 0)
        {
            timer.text = "You Win";
            winningState.SetActive(true);
        }
    }
}
