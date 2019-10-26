/*
		 * (Emma Behymer)
		 * (CubeScript.cs)
		 * (Assignment 8)
		 * (This is what triggers all the events and is attached to the cube)
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
    //refernce to other script
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //call the UI method
        UIManager.Instance.DisplayPrompt();
        //cancel the invoke repeating
        SpawnManager.Instance.Cancel();
    }
}
