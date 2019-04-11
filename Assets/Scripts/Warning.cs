using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : State
{
    public override void Execute()
    {
        Debug.Log("Mirar al player");
        
        transform.LookAt(Jugador.transform.position) ;
    }
}
