/*
		 * (Emma Behymer)
		 * (CollectibleSpawnManager.cs)
		 * (Assignment 10)
		 * (Creates new collectibles and allows for them to spawn randomly with a random color)
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{
    public List<GameObject> collectables;
    public List<GameObject> multicolorCollectibles;

    private GameObject playerObj;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        playerTransform = playerObj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {

            for (int i = 1; i<= 3; i++) {
                GameObject itemToPaint = collectables[Random.Range(0, 2)];
                itemToPaint.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                multicolorCollectibles.Insert(Random.Range(0, multicolorCollectibles.Count + 1), itemToPaint);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {

           
            GameObject objectToSpawn = multicolorCollectibles[multicolorCollectibles.Count - 1];
            float xRand = Random.Range(-5, 5);
            float zRand = Random.Range(-5, 5);
            Vector3 spawnPos = playerTransform.position + playerTransform.forward * 10.0f + new Vector3(xRand, 0, zRand);
            Instantiate(objectToSpawn, spawnPos, playerTransform.rotation);
            multicolorCollectibles.RemoveAt(multicolorCollectibles.Count - 1);
           

        }
    }
}
