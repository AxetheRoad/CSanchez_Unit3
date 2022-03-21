using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsPrefab;
    private Vector3 spawnObj = new Vector3(15, 0, 0);
    private PlayerController playerCtrl;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs",2,2);
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
 
    void SpawnObs()
    {
        if (playerCtrl.gameOver == false)
        {
            Instantiate(obsPrefab, spawnObj, obsPrefab.transform.rotation);
        }
            
    }
}
