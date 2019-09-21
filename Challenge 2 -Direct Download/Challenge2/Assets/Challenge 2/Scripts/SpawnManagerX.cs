/*
		 * (Emma Behymer)
		 * (SpawnManagerX.cs)
		 * (Assignment4)
		 * (Allows for a ball to randomly spawn from an array of 3 & they spawn at a random time between 3-5 seconds)
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
  

   

    // Start is called before the first frame update
    void Start()
    {
        //Random.Range can only be called in Start or a method
        float spawnInterval = Random.Range(3.0f, 5.1f); //since it exculdes the high end limit I made it 5.1 so 5.0 would be included
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
       int index = Random.Range(0, 3); //same as above 3 to include 2

    // Generate random ball index and random spawn position
    Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }

}
