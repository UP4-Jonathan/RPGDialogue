using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {
    public NavMeshAgent playerAgent;
    private bool hasInteracted;
    private bool isEnemy;

    private void Update()
    {
        if(!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {
            if(playerAgent.remainingDistance <= playerAgent.stoppingDistance )
            {
                print(gameObject.name);
                if(!isEnemy)
                    Interact();
                EnsureLookDirection();
                hasInteracted = true;
            }
        }
    }

    void EnsureLookDirection()
    {
        playerAgent.updateRotation = false;
        Vector3 lookDirection = new Vector3(transform.position.x, playerAgent.transform.position.y, transform.position.z);
        playerAgent.transform.LookAt(lookDirection);
        playerAgent.updateRotation = true;
    }

    public virtual void MoveToInteraction( NavMeshAgent a)
    {
        isEnemy = gameObject.tag == "Enemy";
        Debug.Log(isEnemy.ToString());
        hasInteracted = false;
        playerAgent = a;
        playerAgent.stoppingDistance = 3f;
        playerAgent.SetDestination(transform.position);
    }

    public virtual void Interact()
    {
        Debug.Log("Interactable Class");    
    }
	
}
