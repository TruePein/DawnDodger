using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 10f;
    bool facingRight = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(hMove * maxSpeed, vMove * maxSpeed);
        if (hMove > 0 && !facingRight)
        {
            Flip();
        }else if (hMove < 0 && facingRight)
        {
            Flip();
        }
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
