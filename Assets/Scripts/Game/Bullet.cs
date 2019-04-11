using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float damage = 10F;

    private Character instigator;

    private Rigidbody myRigidbody;

    public Character Instigator
    {
        get { return instigator; }
        set { instigator = value; }
    }

    public void Shoot(Character character)
    {
        Instigator = character;
        myRigidbody.AddForce(transform.forward * character.ShootForce, ForceMode.Impulse);
    }

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        
    }

    private void DestroyObject()
    {
        gameObject.SetActive(false);
      
    }

    private void OnDestroy()
    {
        CancelInvoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            Character character = collision.gameObject.GetComponent<Character>();

            if (character != null && instigator != character)
            {
                Debug.Log("Entra a modificar hp");
                character.ModifyHP(damage * -1);
            }
        }

        if (collision.gameObject.Equals(instigator.gameObject))
        {
            gameObject.SetActive(false);
        }
    }
}