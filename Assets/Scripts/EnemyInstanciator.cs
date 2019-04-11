using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstanciator : MonoBehaviour
{

  public  static EnemyInstanciator instance;

    [SerializeField]
    AICharacter[] enemies;

    [SerializeField]
    int count;

    [SerializeField]
    float radius;

    private void Start()
    {
        if(instance == null)
        {
            instance=this;
        } else
        {
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public void Defeated(GameObject enemy)
    {
        enemy.SetActive(false);
        count++;
        if(count==enemies.Length)
        {
            count = 0;
            SpawnEnemies();
        }
    }

    public void SpawnEnemies()
    {
        for(int i=0;i<enemies.Length;i++)
        {
            Vector3 spawn = GetPointDestination();
            enemies[i].gameObject.SetActive(true);
            enemies[i].transform.position = spawn;
            
        }
        

    }

    public Vector3 GetPointDestination()
    {
        Vector3 pointDestination = new Vector3(Random.Range(transform.position.x - radius, transform.position.x + radius), transform.position.y, Random.Range(transform.position.z - radius, transform.position.z + radius));
       
        return pointDestination;
    }


}
