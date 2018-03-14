using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerShaped : MonoBehaviour {

    public GameObject typeEnemy;
	
	void Start () {
		foreach(Transform child in transform)
        {
            Instantiate(typeEnemy, child.transform.position, typeEnemy.transform.rotation);
            Destroy(child.gameObject);
        }
        Destroy(gameObject);
	}
	

}
