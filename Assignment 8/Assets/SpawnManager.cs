/*
		 * (Emma Behymer)
		 * (SpawnManager.cs)
		 * (Assignment 8)
		 * (This spawns the boxes and allows for the cancelization of the spawning)
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager instance;

    public static SpawnManager Instance { get { return instance; } }

    public GameObject BoxSmall;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 2);

    }

    void SpawnObject()
    {
        //allows for the spawning around the player
        float x = GameObject.FindGameObjectWithTag("Player").transform.position.x + Random.Range(2f, 5f);
        float z = GameObject.FindGameObjectWithTag("Player").transform.position.z + Random.Range(-2f, 5f);
        Instantiate(BoxSmall, new Vector3(x, 2, z), Quaternion.identity);
    }

    public void Cancel() { CancelInvoke(); }

    // Update is called once per frame
    void Update()
    {
        
    }
}
