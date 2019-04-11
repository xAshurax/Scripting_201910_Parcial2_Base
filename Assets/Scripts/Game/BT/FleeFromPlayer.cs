using UnityEngine;
using UnityEngine.AI;
public class FleeFromPlayer : State
{
    [SerializeField]
    NavMeshAgent agent;
    private Transform startTransform;
   

    


    public override void Execute()
    {
        var dir = Jugador.transform.position - transform.position;

        agent.SetDestination(transform.position - dir * 10);

    }

    


    

}
