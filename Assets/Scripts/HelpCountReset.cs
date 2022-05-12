using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpCountReset : MonoBehaviour
{
    public GameObject NextCollider;
    public HelpCountCtrl HelpScript;

    // Start is called before the first frame update
    void Start()
    {
        NextCollider.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HelpScript.helpcount = 0;
            NextCollider.SetActive(true);
        }
    }
}
