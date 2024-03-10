using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ChasePlayer : MonoBehaviour
{

    GameObject player;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player");
        agent = this.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(player.transform.position);

    }
}
