using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;
    public int hp;

    Vector3 direction;

	// Use this for initialization
	protected void Start () {
        direction = new Vector3(0, -1, 0)*speed;
        GetComponent<Rigidbody2D>().velocity = direction;
    }
	

    protected virtual void die()
    {
        Destroy(gameObject);
    }

   public void getDamage(int dmg){
        hp -= dmg;
        if (hp < 0) die();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "destroy")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Bullet")
        {
            GetComponent<Rigidbody2D>().velocity = direction = new Vector3(0, -1, 0) * speed; ;
        }

    }
}
