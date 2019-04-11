using UnityEngine;
using UnityEngine.AI;

public abstract class State : MonoBehaviour
{
  

    [SerializeField]
    private State nextState;

    [SerializeField]
   private GameObject jugador;

    public GameObject Jugador { get => jugador; set => jugador = value; }

    public abstract void Execute();

    private void SwitchToNextState()
    {
        if (nextState != null)
        {
            Toggle(false);
            nextState.Toggle(true);
        }
    }

    public void Toggle(bool val)
    {
        this.enabled = val;

        if (val)
        {
            Execute();
        }
    }

}