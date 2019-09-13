using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
		 * (Emma Behymer)
		 * (FollowPlayerX.cs)
		 * (Homework #3)
		 * (This is the script for the Camera & it allows for the Camera to follow the plane)
		 */


public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(30, 0, 10);
        transform.position = plane.transform.position + offset;
    }
}
