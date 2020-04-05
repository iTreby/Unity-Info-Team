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
        InvokeRepeating("Spawning", 5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Targer")
        {
            Destroy(this);
        }
    }



    public void Spawning()
    {
        Instantiate(Monster, new Vector3(2f,-4f,30),Portal.rotation);
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Monster, Portal);
            yield return new WaitForSeconds(5f);
        }
    }
}
