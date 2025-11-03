using Unity.VisualScripting;
using UnityEngine;


public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform shootPoint { get; set; }
    [field: SerializeField] public float ReloadTime { get; set; }
    [field: SerializeField] public float WaitTime { get; set; }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(100);
        ReloadTime = 1.0f;
        WaitTime = 0.0f;
        FindAnyObjectByType<UIPlayer>()?.UpdateHealthUI();
    }

    public void OnHitWithenemy(Enemy enemy)
    {

        TakeDamage(enemy.Damagehit);
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            Debug.Log($"{this.name} hit with {enemy.name}!");
            OnHitWithenemy(enemy);
        }
    }

  private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }





    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Fixed Update: " + Time.deltaTime);
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && WaitTime >= ReloadTime)
        {
            var bullet = Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            Banana banana = bullet.GetComponent<Banana>();

            if (banana != null)
            {

                banana.InitWeapon(20, this);

            }

            WaitTime = 0.0f;
        
        }
 
       

    }
}
