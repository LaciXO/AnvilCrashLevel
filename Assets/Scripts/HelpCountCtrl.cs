using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpCountCtrl : MonoBehaviour
{

    public GameObject HelpText;
    public int helpcount;

    // Start is called before the first frame update
    void Start()
    {
        helpcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (helpcount >= 3)
        {
            HelpText.SetActive(true);
        }

        else
        {
            HelpText.SetActive(false);
        }
    }
}
