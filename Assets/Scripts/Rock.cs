using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb;
    public Vector2 force;



    public override void Move()
    {
        force = new Vector2(GetShootPoint() * 9, 10);
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
            character.TakeDamage(this.damage);
    }













    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damage = 40;
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
