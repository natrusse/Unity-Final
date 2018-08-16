using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketP2 : MonoBehaviour {

    public float despawnTime = 5;
    private float timer = 0;
    private Manager M;

    // Use this for initialization
    void Start()
    {
        M = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= despawnTime)
        {

            Destroy(gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.gameObject.tag == "Player1")
        {
            Debug.Log("Enemy Player is dead.");
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
            M.P1Death();
        }
        else if (col.collider.gameObject.tag == "Rocket")
        {
            Debug.Log("Enemy Rocket destroyed");
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
        }
    }
}

