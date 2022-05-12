using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public HelpCountCtrl helpScript;

    void Start()
    {

    }

    void OnTriggerEnter (Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        helpScript.helpcount++;
        Debug.Log(helpScript.helpcount);
    }
}
