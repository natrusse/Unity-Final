using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public GameObject player1Prefab;
    public GameObject player2Prefab;

    [HideInInspector()] public GameObject P1currentShip;
    [HideInInspector()] public GameObject P2currentShip;

    public GameObject P1infoUI;
    public GameObject P2infoUI;
    public GameObject P1GameOverUI;
    public GameObject P2GameOverUI;

    public int P1ships = 0;
    public int P2ships = 0;



    // Use this for initialization
    void Start()
    {
        P1infoUI.SetActive(true);
        P2infoUI.SetActive(true);

        P1currentShip = Instantiate(player1Prefab);
        P1currentShip.transform.position = new Vector3(0, 0, 0);
        P1currentShip.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        P2currentShip = Instantiate(player2Prefab);
        P2currentShip.transform.position = new Vector3(-35, 0, 0);
        P2currentShip.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        P1ships += 1;
        P2ships += 1;

        P1GameOverUI.SetActive(false);
        P2GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void P1Death()
    {
        P1GameOverUI.SetActive(true);
    }

    public void P2Death()
    {
        P2GameOverUI.SetActive(true);
    }
}
