using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampLight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject []  light = new GameObject[5];
    private bool playerInZone;
    private Light myLight;


    private void start() 
    {
        playerInZone = false;
    
    }
    
     void update()
    {
        if(playerInZone && gameObject.tag == "Mordernroom" && Input.GetKey(KeyCode.E)) 
        {
            myLight = GetComponent<Light>();
            myLight.enabled = myLight.enabled;
            gameObject.GetComponent<AudioSource>().Play();
        }

       else if (playerInZone && gameObject.tag == "Villageroom" && Input.GetKey(KeyCode.E))
        {
            myLight.enabled = !myLight.enabled;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }



void OnTriggerEnter(Collider other) {
       

    if (other.gameObject.tag == "player" )
    {

            playerInZone = true;
    }

  }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
    {

            playerInZone = false;
    }
    }

}
