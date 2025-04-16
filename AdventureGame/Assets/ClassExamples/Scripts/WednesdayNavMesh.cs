using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WednesdayNavMesh : MonoBehaviour
{
	public Transform target;
	private NavMeshAgent agent;
   
 // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
		agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
		{
			agent.SetDestination(target.position);
		}

    }
}
