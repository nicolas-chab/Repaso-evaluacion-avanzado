using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class agentscript : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform destinationtransform;
    public float remainingDistance;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      
        agent.destination = destinationtransform.position;
        if (agent.isStopped==true)
        {
            Destroy(gameObject);
        }
    }
}
