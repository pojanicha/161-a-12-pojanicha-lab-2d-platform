using UnityEngine;

public class Croccodile : Enemy,IShootable
{
    [SerializeField] private float atkRange;
    public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform shootPoint { get; set; }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(50);
        Damagehit = 30;
        ReloadTime = 1;

        atkRange = 6.0f;
        player = GameObject.FindFirstObjectByType<Player>();
    }

    private void FixedUpdate()
    {
        Behavior();

        WaitTime += Time.fixedDeltaTime;
    }


    public override void Behavior()
    {
        //find distance between Croccodile and Player
        Vector2 distance = transform.position - player.transform.position;
        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s atk range!");
            Shoot();
        }
    }


    public void Shoot()
    {
        if (WaitTime < ReloadTime) return;
        WaitTime = 0.0f;


            anim.SetTrigger("Shoot");
            var bullet = Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            Rock rock = bullet.GetComponent<Rock>();

            if (rock != null)
            {
                rock.InitWeapon(20, this);
                rock.Move();

        }
            


        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
