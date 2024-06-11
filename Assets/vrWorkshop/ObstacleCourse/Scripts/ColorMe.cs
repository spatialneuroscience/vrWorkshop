using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMe : MonoBehaviour {

    public Material originalColor;
    public Material newColor;
    public bool hasBeenHit; 

    private void OnTriggerEnter(Collider other)
    {
        //if bool is false and other Game Object's name is "Burt" in hierarchy...
        if (hasBeenHit == false && other.name == "Burt")
            {
                //Show in console that the collision is occuring
                Debug.Log("COLLIDED");
                //Grab component on gameObject and change material to newColor
                GetComponent<Renderer>().material = newColor;
                hasBeenHit = true;
            }
            //but if bool is true...
             else if (hasBeenHit == true)
            {
                //Change back to original material and change bool back to false
                GetComponent<Renderer>().material = originalColor;
                hasBeenHit = false;
            }
        }
    }


