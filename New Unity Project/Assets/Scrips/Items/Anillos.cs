using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anillos : MonoBehaviour
{
    public Transform[] position;

    public GameObject[] spawn;

    // Start is called before the first frame update
    void Start()
    {
        for(int x=0; x<5; x++){
            Debug.Log(x);
            Instantiate(spawn[x],position[x].position,spawn[x].transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
