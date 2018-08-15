using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketP1 : MonoBehaviour {

    public float despawnTime = 5;
    private float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer >= despawnTime)
        {

            Destroy(gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.gameObject.tag == "Player2")
        {
            Debug.Log("Enemy Player is dead.");
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
        }
        else if (col.collider.gameObject.tag == "Rocket")
        {
            Debug.Log("Enemy Rocket destroyed");
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
        }
    }
}
