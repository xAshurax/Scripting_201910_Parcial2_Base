using UnityEngine;
public class Attack : State
{

    float tiempoShoot, tiempo;
    AICharacter me;
    private void Start()
    {
         me = GetComponent<AICharacter>();
        tiempo = 0;
        tiempoShoot = 0.8f;
    }

    private void Update()
    {
        tiempo += Time.deltaTime;
    }


    public override void Execute()
    {
      
        if (tiempo >= tiempoShoot)
        {
            me.SpawnBullet();
            tiempo = 0;
        }
        
        
        

        
    }
   
    
    
}