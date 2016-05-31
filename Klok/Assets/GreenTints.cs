using System.Collections;
using System;
using UnityEngine;

public class GreenTints : MonoBehaviour {

    private void randomizer()
    { int greenRnd = UnityEngine.Random.Range(150, 174);
        gameObject.GetComponent<Renderer>().material.color = new Color(greenRnd, 191, 63);
    }




// Use this for initialization
void Start () {
        randomizer();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.H))
        {
            randomizer();
        }
    }
}
