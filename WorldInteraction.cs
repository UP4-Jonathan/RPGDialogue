using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour {
    [SerializeField]
    NavMeshAgent navAgent;

	// Use this for initialization
	void Start () {
        navAgent = GetComponent<NavMeshAgent>();		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();		
	}

    void GetInteraction()
    {  
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit,Mathf.Infinity))
        {        
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.CompareTag("Interactable"))
            {
                hitObject.GetComponent<Interactable>().MoveToInteraction(navAgent);
            }
            else if(hitObject.CompareTag("Enemy"))
            {
                hitObject.GetComponent<Interactable>().MoveToInteraction(navAgent);
            }
            //move
            else
            {
                if(GroundTargetController.Instance.isGroundTargeting)
                {
                    GroundTargetController.Instance.ActivateGroundTarget("GroundObject");
                }
                else
                {
                    navAgent.stoppingDistance = 0;
                    navAgent.SetDestination(hit.point);
                }
            }
        }
    }
}
