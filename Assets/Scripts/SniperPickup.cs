using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperPickup : MonoBehaviour {

    public int increase = 3;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SnaiperRifle launcher = other.GetComponentInChildren<SnaiperRifle>();
            if (launcher.inventoryAmmo < launcher.maxAmmo)
            {
                if (launcher.inventoryAmmo + increase <= launcher.maxAmmo)
                {
                    launcher.inventoryAmmo += increase;
                    Destroy(gameObject);
                }
                else if (launcher.inventoryAmmo + increase >= launcher.maxAmmo)
                {
                    launcher.inventoryAmmo = launcher.maxAmmo;
                    Destroy(gameObject);
                }
            }
        }
    }
}
