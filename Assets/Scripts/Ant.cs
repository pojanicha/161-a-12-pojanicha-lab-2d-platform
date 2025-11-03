using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Ant : Enemy


{
    [SerializeField]private Vector2 velocity;
    public Transform[] MovePoint;









    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(20);
        Damagehit = 20;
        FindAnyObjectByType<UIAnt>()?.UpdateHealthUI();

        //Set speed and direction of the ant
        velocity = new Vector2(-1.0f, 0.0f);


    }


    public override void Behavior()
    {
        //move from current position
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (velocity.x < 0 && rb.position.x <= MovePoint[0].position.x)
        {
            Flip();
        }
        //move right และเกินขอบขวา
        if (velocity.x > 0 && rb.position.x >= MovePoint[1].position.x)
        {
            Flip();
        }

    }

    //flip ant to the opposite direction
    public void Flip()
    {
        velocity.x *= -1; //change direction of movement
                          //Flip the image
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
  
    
    
    private void FixedUpdate()
    {
        Behavior();
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
