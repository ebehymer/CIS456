using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
		 * (Emma Behymer)
		 * (SpinPropellerX.cs)
		 * (Homework #3)
		 * (This is the script for the Propeller, it allows for it to spin once per frame along the z axis)
		 */


public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //allows for the rotation of the Propeller 
        //the 360f allows for one complete circular rotation per frame
        transform.Rotate(Vector3.forward * Time.deltaTime * 360f);
    }
}
