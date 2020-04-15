using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour
{
    [SerializeField] GameObject Monster;
    [SerializeField] Transform Portal;

    // Start is called before the first frame update
    void Start()
    {
        //Calling the spawn AI each 2.5 seconds
        InvokeRepeating("Spawning", 2.5f, 2.5f);
    }
    //Spawn AI
    public void Spawning()
    {
        Instantiate(Monster, new Vector3(2f,-4f,30),Portal.rotation);
    }

}
