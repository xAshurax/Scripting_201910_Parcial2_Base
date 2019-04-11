using UnityEngine;
using UnityEngine.AI;
public class DoKamikazeAttack : State
{
    [SerializeField]
    NavMeshAgent agent;

    [SerializeField]
    Player playerin;

    [SerializeField]
    AICharacter me;

   

    public override void Execute()
    {
        agent.SetDestination(Jugador.transform.position);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Jugador)
        {

            me.ModifyHP(-1000);

            playerin.ModifyHP(-20);
            

        }
    }
}