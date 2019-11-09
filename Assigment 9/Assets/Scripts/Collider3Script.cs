/*
		 * (Emma Behymer)
		 * (Collider3Script.cs)
		 * (Assignment9)
		 * (Moves the player upwards by using Impulse)
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider3Script : MonoBehaviour
{
    public float hoverForce;


    void OnTriggerEnter(Collider other)
    {

        other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Impulse);
    }
}
