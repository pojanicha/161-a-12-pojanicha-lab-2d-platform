using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //attribute

    private float health;
    public float Health 
    { get => health; 
      set => health = (value < 0 ) ? 0: value;}

    public float MaxHealth { get; set; }


    protected Animator anim;
    protected Rigidbody2D rb;


    [SerializeField] UIHealthBar healthBar;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        healthBar = GetComponent<UIHealthBar>();
    }







    //Method s for initialization

    public void Intialize(int startHealth)
    { 
        Health = startHealth;
        MaxHealth = startHealth;
        Debug.Log($"{this.name} initialized with Health : {this.Health}.");
        healthBar = GetComponentInChildren<UIHealthBar>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }



    //Methods

    public void TakeDamage(int damage)
    { 
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}.Current Health : {Health}");

        if (healthBar != null)

        {

            healthBar.UpdateHealthBar(Health, MaxHealth);

        }
       

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
        healthBar.UpdateHealthBar(Health, MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
