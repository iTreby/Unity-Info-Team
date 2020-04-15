using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text timer;
    [SerializeField] GameObject winningState;
    private float timeLeft = 120.0f;



    private static GameManager _instance = null;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        winningState.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        //Reduce the timer, once its 0 then player wins
        timeLeft -= Time.deltaTime;
        timer.text = "TIME : " + (int)timeLeft;
        if(timeLeft < 0)
        {
            timer.text = "You Win";
            winningState.SetActive(true);
        }
    }
}
