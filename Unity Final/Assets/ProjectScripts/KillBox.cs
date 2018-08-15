using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {

    void OnTriggerExit2D(Collider2D playerShip)
    {
        if (playerShip.gameObject.tag == "Player1")
        {
            Debug.Log("Player committed Suicide");
            Destroy(playerShip.gameObject);
        }
        else
        {
            Debug.Log("Exited Trigger");
            Destroy(playerShip.gameObject);
        }
    }
}
