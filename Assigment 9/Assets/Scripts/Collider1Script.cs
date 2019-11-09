/*
		 * (Emma Behymer)
		 * (Collider1Script.cs)
		 * (Assignment9)
		 * (Moves the player upwards by using Acceleration)
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider1Script : MonoBehaviour
{
    public float hoverForce;


    void OnTriggerStay(Collider other)
    {
       
        other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}
