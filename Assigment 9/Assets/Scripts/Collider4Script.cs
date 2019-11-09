/*
		 * (Emma Behymer)
		 * (Collider4Script.cs)
		 * (Assignment9)
		 * (Moves the player upwards by using Velocity Change)
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider4Script : MonoBehaviour
{
    public float hoverForce;


    void OnTriggerEnter(Collider other)
    {

        other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.VelocityChange);
    }
}
