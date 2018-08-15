using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {

    public float maxspeed = 6;
    public float rotspeed = 6;
    public Transform Blaster;
    public GameObject bulletPrefab;
    public float bulletForce = 30;
    public float fireRate = 0.5f;
    private float fireTimer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            fireTimer += Time.deltaTime;
            if (fireTimer >= fireRate)
            {
                fireTimer = 0;

                //fires the guns
                GameObject bullet = Instantiate(bulletPrefab, Blaster.transform.position, Blaster.transform.rotation);
                bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.up * bulletForce, ForceMode2D.Impulse);

                // for future reference, this is effected by background colliders. if moving towards edge of background, remove 2d collider
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            fireTimer = fireRate;
        }
        

        if (Input.GetKey(KeyCode.LeftShift))
        {
            //left strafe with shift + a
            if (Input.GetKey(KeyCode.A)) 
            {
                transform.Translate(Vector2.left * maxspeed * Time.deltaTime);
            }
            //right strafe with shift + d
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * maxspeed * Time.deltaTime);
            }
        }
        else
        {
            // WASD Controls
            //forward movement with w
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * maxspeed * Time.deltaTime);
            }
            //backward movement with s
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * maxspeed * Time.deltaTime);
            }
            //left rotation with a
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * rotspeed * 2);
            }
            //right rotation with d
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back * Time.deltaTime * rotspeed * 2);
            }
        }
    }
}
