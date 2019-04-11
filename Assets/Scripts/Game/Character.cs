using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private float maxHP;

    [SerializeField]
    private int count;

    [SerializeField]
    private Bullet [] bullet;

    [SerializeField]
    private float shootForce = 20F;

    [SerializeField]
    private Transform bulletSpawnPosition;

    private float hp;

    public float HP
    {
        get { return hp; }
         set { hp = value; }
    }

    public float ShootForce { get { return shootForce; } }

    public void ModifyHP(float delta)
    {
        HP += delta;

        if (HP <= 0F)
        {
            OnDeath();
        }
    }

    protected virtual void OnDeath()
    {
        if(this is AICharacter)
        {
            HP = maxHP;
            EnemyInstanciator.instance.Defeated(gameObject);
        }
        if(this is Player)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        HP = maxHP;
    }

    public void SpawnBullet()
    {
        bullet[count].CancelInvoke();
        bullet[count].gameObject.SetActive(true);
        bullet[count].Invoke("DestroyObject", 10F);
        bullet[count].transform.position = bulletSpawnPosition.position;
        bullet[count].transform.rotation = transform.rotation;
        bullet[count].Shoot(this);
        count++;
        if(count == bullet.Length)
        {
            count = 0;
        }
    }
}