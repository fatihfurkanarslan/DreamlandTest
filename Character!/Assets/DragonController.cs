using UnityEngine;
using System.Collections;

public class dragonControllerScript : MonoBehaviour
{

    public float maxSpeed = 10f;
    bool facingLeft = true;
    public Vector2 velocity;
    private Rigidbody2D rigi;

    void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rigi.velocity = new Vector2(1f, 2f);
        if (move > 0 && !facingLeft)
            Flip();
        if (move < 0 && facingLeft)
            Flip();
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale *= -1;
        transform.localScale = theScale;
    }

}
