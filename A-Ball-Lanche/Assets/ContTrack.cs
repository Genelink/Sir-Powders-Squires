using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContTrack : MonoBehaviour
{   
    public GameObject SpawnPoint;
    public GameObject NextPiece;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        Debug.Log("It Works");
        Instantiate(NextPiece, SpawnPoint.transform.position, NextPiece.transform.rotation);
    }

}
