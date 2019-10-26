/*
		 * (Emma Behymer)
		 * (UIManager.cs)
		 * (Assignment 8)
		 * (This displays the canvas text)
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static UIManager instance;

    public static UIManager Instance { get { return instance; } }

    public GameObject canvas;


    private void Awake()
    {
            instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public  void DisplayPrompt() {

        //sets the canvas active
        canvas.SetActive(true);
       // Debug.Log("Canvas was set to active");
        //start courutine to make canvas inactive after 5 seconds
        StartCoroutine(setInactive());
       // Debug.Log("Canvas was set to inactive");
    }

    IEnumerator setInactive() {

        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
