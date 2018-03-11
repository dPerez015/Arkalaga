using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;
    public float hp;

    Vector3 direction;

	// Use this for initialization
	void Start () {
        direction = new Vector3(0, -1, 0)*speed;
        GetComponent<Rigidbody2D>().velocity = direction;
    }
	
	// Update is called once per frame
	void Update () {
      
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "destroy")
        {
            Destroy(this.gameObject);
        }
    }
}
