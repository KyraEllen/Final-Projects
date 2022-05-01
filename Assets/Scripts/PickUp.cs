using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public enum PickupType {Key};
    public PickupType currentPickup;
    
    public int pickupAmount;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
       playerController = GameObject.Find("Player").GetComponent<PlayerController>(); 
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pickupAmount;
                Debug.Log("You have picked up a goldent key!");
            }

            Destroy(gameObject);
        }
    }
}

