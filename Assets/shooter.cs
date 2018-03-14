using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {
    public GameObject bullet;
    float timeLastShoot;
    public float cooldown;
	
	// Update is called once per frame
	public void shoot (Vector2 speed) {
        if (timeLastShoot > cooldown){
            GameObject newbullet = Instantiate(bullet, transform.position, transform.rotation);
            newbullet.GetComponent<Bullet>().init(speed);
            timeLastShoot -= cooldown;
        }
    }

    public void Update()
    {
        timeLastShoot += Time.deltaTime;
    }
}
