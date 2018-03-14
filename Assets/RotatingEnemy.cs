using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingEnemy : Enemy {

    public float rotSpeed;

	// Use this for initialization
	void Start () {
        base.Start();
        int direction =Random.Range(0, 2);
        
        if(direction==0)
            GetComponent<Rigidbody2D>().angularVelocity = rotSpeed;
        else 
            GetComponent<Rigidbody2D>().angularVelocity = -rotSpeed;
    }
	

}
