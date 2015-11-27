using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    bool playerInRange;

    void OnCollisionStay(Collision Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void Update ()
    {
        if (playerInRange)
        {
            Debug.Log("attack");
        }
    }
}
