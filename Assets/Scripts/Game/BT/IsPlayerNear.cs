using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerNear : Selector
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    float radiusWarning, radiusAction;

    [SerializeField]
    State iddle, warning, action;

    [SerializeField]
    AICharacter self;

    public override void Execute()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance>radiusWarning) {
            self.SetNewState(iddle);
            iddle.Execute();
            Debug.Log("Iddle");
        } //Aqui van cosas de iddle

        else if((distance<= radiusWarning)&& (distance>radiusAction)) {
            self.SetNewState(warning);
            warning.Execute();
            Debug.Log("Warning");


        } //Aqui van cosas de warning

        else if (distance<= radiusAction)
        {
            self.SetNewState(action);
            action.Execute();
            Debug.Log("Action");
        } //Cosas de action

        
     
        
    }

  
}