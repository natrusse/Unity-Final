using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

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

        if (Input.GetKey(KeyCode.Mouse0))
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

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            fireTimer = fireRate;
        }
        // Arrow Key Controls
        if (Input.GetKey(KeyCode.RightShift))
        {
            //left strafe with left arrow + right shift
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * Time.deltaTime * maxspeed);
            }
            //right strafe with right arrow + right shift
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * Time.deltaTime * maxspeed);
            }
        }
        else
        {
            //forward with up arrow
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * maxspeed * Time.deltaTime);
            }
            //backward with down arrow
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * maxspeed * Time.deltaTime);
            }
            //left rotation with left arrow
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * rotspeed * 2);
            }
            //right rotation with right arrow
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back * Time.deltaTime * rotspeed * 2);
            }
        }

    }
}
