using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    Transform player;
    NavMeshAgent nav;
    bool playerInRange;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void Update ()
    {
        if (playerInRange)
        {
        nav.SetDestination(player.position);
        }
    }
}
