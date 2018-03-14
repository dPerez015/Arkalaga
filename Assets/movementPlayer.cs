using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPlayer : MonoBehaviour {

    public float speed;

    protected Rigidbody2D rb;
    public shooter shooter;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update () {
        rb.velocity = new Vector2(speed, 0) * Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
            shooter.shoot(rb.velocity);
        
	}
}
