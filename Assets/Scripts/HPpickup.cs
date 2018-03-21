using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPpickup : MonoBehaviour {

   public int regen = 25;
   public bool canOverheal = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("collided with something " +other.tag);
        if(other.tag == "Player")
        {

            if(other.GetComponent<Health>().player_health + regen >= 101)
            {
                if (canOverheal)
                {
                    other.GetComponent<Health>().player_health += regen;
                    Destroy(gameObject);
                }
                else
                {
                    other.GetComponent<Health>().player_health = 100;
                    Destroy(gameObject);
                }
            } else
            {
                other.GetComponent<Health>().player_health += regen;
                Destroy(gameObject);
            }

        }
    }
}
