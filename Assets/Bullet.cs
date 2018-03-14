using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Vector2 speed;
    public float verticalSpeed;
    public float maxHorizontalSpeed;
    public int dmg;

    float initialVel;

    public void init(Vector2 addSpeed)
    {
        speed = new Vector2(0, verticalSpeed);
        // speed += addSpeed/verticalSpeed;
        addSpeed = Vector2.ClampMagnitude(addSpeed, maxHorizontalSpeed);
        GetComponent<Rigidbody2D>().velocity = speed + addSpeed;
        initialVel = GetComponent<Rigidbody2D>().velocity.magnitude;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       // Debug.Log("ay");
        if (col.gameObject.tag == "destroy")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Enemy")
        {
           // Vector2 contact = col.contacts[0].normal;
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * initialVel;
            col.gameObject.GetComponent<Enemy>().getDamage(dmg);
            dmg += (dmg / 2);
            GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0, 0.3f, 0.3f, 0);
        }
    }

   // void OnTriggerEnter2D(Coll)



}
