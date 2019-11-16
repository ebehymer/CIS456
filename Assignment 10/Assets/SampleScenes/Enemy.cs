/*
		 * (Emma Behymer)
		 * (Enemy.cs)
		 * (Assignment 10)
		 * (A unique class that creates a basic enemy)
		 */
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    public string name { get; set; } 
    public float speed { get; set; }
    public static int count { get; set; }
    public float health { get; set; }


     public  Enemy() {

        name = "Hello World";
        speed = 10.0f;
        count++;
     }

     public  Enemy(string n, float f){

        name = n;
        speed = f;
        count++;
     }

    public override string ToString()
    {
        return name + " runs at " + speed + " km per hour.";
    }
}
