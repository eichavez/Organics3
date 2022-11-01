using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public int green_keys = 0;
public int blue_keys = 0;
public int red_keys = 0;

private void OnTriggerEnter(Collider other)
    {
        print("Trigger");
        // Green Key
        if (other.gameObject.tag == "Key Green")
        {
            green_keys++;
            print("Key Green " + green_keys);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Door Green")
        {
           print("Ran into Door Green");
           if(green_keys >= other.gameObject.GetComponent<Door>().number_of_locks)
            {
                print("had Green Keys");
                green_keys -= other.gameObject.GetComponent<Door>().number_of_locks;
                other.gameObject.SetActive(false);
            }
        }
        // Blue Key
        if (other.gameObject.tag == "Key Blue")
        {
            blue_keys++;
            print("Key Blue " + blue_keys);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Door Blue")
        {
            print("Door Blue");
            if (blue_keys >= other.gameObject.GetComponent<Door>().number_of_locks)
            {
                print("Blue Key");
                blue_keys -= other.gameObject.GetComponent<Door>().number_of_locks;
                other.gameObject.SetActive(false);
            }
        }
        // Red Key
        if (other.gameObject.tag == "Key Red")
        {
            red_keys++;
            print("Key Red " + red_keys);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Door Red")
        {
            print("Door Red");
            if (red_keys >= other.gameObject.GetComponent<Door>().number_of_locks)
            {
                print("Red Keys");
                red_keys -= other.gameObject.GetComponent<Door>().number_of_locks;
                other.gameObject.SetActive(false);
            }
        }
    }
}  // end of Player Script
