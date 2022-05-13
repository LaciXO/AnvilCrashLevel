using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public GameObject txtToDisplay;             //display the UI text

    private bool PlayerInZone;                  //check if the player is in trigger

    public GameObject trapdoorParent;
    public GameObject UIElement;
    public GameObject collectable;
    public Renderer rend;

    private void Start()
    {
        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
        collectable.GetComponent<Renderer>().enabled = true;
    }

    private void Update()
    {
        if (PlayerInZone && Input.GetMouseButtonDown(0))           //if in zone and press Left Click
        {
            txtToDisplay.SetActive(false);
            collectable.GetComponent<AudioSource>().Play();
            trapdoorParent.GetComponent<Animator>().Play("Open");
            UIElement.SetActive(!UIElement.activeSelf);
            collectable.GetComponent<Renderer>().enabled = false;
            transform.position = new Vector3(0, 10, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}