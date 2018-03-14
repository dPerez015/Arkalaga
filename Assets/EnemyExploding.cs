using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExploding : Enemy {

    public GameObject bullet;
    public int minBullets;
    public int maxBullets;
    int numberBullets;

    void Start()
    {
        base.Start();
        numberBullets = Random.Range(minBullets, maxBullets+1);
    }
    Vector2 generateRandomSpeed()
    {
        Vector2 ret;
        ret.x = Random.Range(-1.0f, 1.0f);
        ret.y = Random.Range(-1.0f, 1.0f);
        return ret.normalized;
    }

    protected override void die(){

        for(int i = 0; i < numberBullets; i++)
        {
            GameObject newbullet = Instantiate(bullet,transform.position,transform.rotation);
            Vector2 randomSpeed = generateRandomSpeed();
            newbullet.GetComponent<Bullet>().init(randomSpeed);
            newbullet.transform.localPosition += new Vector3(randomSpeed.x * 0.5f, randomSpeed.y * 0.5f,0);
            //newbullet.transform.localScale *= 0.8f;
        }
        Destroy(gameObject);
    }
}
