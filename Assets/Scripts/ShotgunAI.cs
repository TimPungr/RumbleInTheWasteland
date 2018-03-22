using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShotgunAI : MonoBehaviour {

    public NavMeshAgent agent;
    public GameObject player;

    // Use this for initialization
    void Start() {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("First Person Controller");
        StartCoroutine(FollowPlayer());

    }

    // Update is called once per frame
    void Update() {

    }


    IEnumerator FollowPlayer()
    {
        for (; ; ) { 
        Debug.Log("Following player");
        agent.SetDestination(player.transform.position);
        yield return new WaitForSeconds(0.5f);
    } }


}
