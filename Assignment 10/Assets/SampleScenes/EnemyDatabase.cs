/*
		 * (Emma Behymer)
		 * (EnemyDatabase.cs)
		 * (Assignment 10)
		 * (A databse of enemies using a dictionary)
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDatabase : MonoBehaviour
{

    public Dictionary<string, Enemy> enemies = new Dictionary<string, Enemy>();
    // Start is called before the first frame update
    void Start()
    {
        
        enemies.Add("Hello World", new Enemy());
        enemies.Add("Hello", new Enemy("Hello", 7.0f));
        enemies.Add("World", new Enemy("World", 9.0f));

     
        if (enemies.ContainsKey("Hello")) { enemies.Remove("Hello"); }

      
        foreach (KeyValuePair<string, Enemy> enemy in enemies) {

            Debug.Log(enemy.ToString());
        }
    }

   
}
