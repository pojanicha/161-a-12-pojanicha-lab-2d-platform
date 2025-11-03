using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //attribute

    private int health;
    public int Health { get => health; set => health = (value < 0) ? 0 : value; }
    public int MaxHealth { get; set; }


    protected Animator anim;
    protected Rigidbody2D rb;


    //Method s for initialization

    public void Intialize(int startHealth)
    { 
        Health = startHealth;
        MaxHealth = startHealth;
        Debug.Log($"{this.name} initialized with Health : {this.Health}.");

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }



    //Methods

    public void TakeDamage(int damage)
    { 
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}.Current Health : {Health}");

        IsDead();

    }


    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log($"{this.name} is dead TT");
            return true;
        
        
        }
        else return false;
    
    
    
    }



















    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
