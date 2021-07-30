using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHazards : MonoBehaviour {

    #region Variables
    //Public

    //Private
    [SerializeField]
    public float minX = 0.0f;                   //MinX spawn Hazard
    [SerializeField]
    public float maxX = 0.0f;                   //MaxX spawn Hazard
    [SerializeField]
    private GameObject[] hazards;               
    [SerializeField]
    private float timeBetweenSpawns = 0.0f;
    private bool canSpawn = false;              //delay posb.
    private int amountOfHazardsToSpawn = 0;
    private int hazardToSpawn = 0;
    #endregion

    #region UnityFunctions
    public void Start()
    {
        canSpawn = true;                        //Temp start
    }
    public void Update()
    {
        if(canSpawn == true)
        {
            StartCoroutine("GenerateHazard");   
        }
    }
    #endregion

    private IEnumerator GenerateHazard()
    {
        canSpawn = false;
        timeBetweenSpawns = Random.Range(0.5f, 2.5f);       
        amountOfHazardsToSpawn = Random.Range(1, 6);        
        for(int i = 0; i < amountOfHazardsToSpawn; i ++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), 20.0f, 4.0f);   
            Instantiate(hazards[hazardToSpawn], spawnPos, Quaternion.identity);     //Spawn hazard
        }
        yield return new WaitForSeconds(timeBetweenSpawns);
        canSpawn = true;
    }
}