using UnityEngine;
using UnityEngine.AI;
public class Idle : State
{
    [SerializeField]
    NavMeshAgent agent;
    
    public override void Execute()
    {


        agent.SetDestination(transform.position);
        Debug.Log("No hacer cosa");
        
    }
}