/*
		 * (Emma Behymer)
		 * (Collider2Script.cs)
		 * (Assignment9)
		 * (Moves the player upwards by using Force)
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2Script : MonoBehaviour
{
    public float hoverForce;


    void OnTriggerStay(Collider other)
    {

        other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Force);
    }

}
