using UnityEngine;
using System.Collections;

public class GreenShades : MonoBehaviour {

    Color[] colorsGreen = new Color[6];

    // Use this for initialization
    void Start()
    {
        colorsGreen[0] = new Color32(0, 250, 154, 1);
        colorsGreen[1] = new Color(0, 255, 127, 1);
        colorsGreen[2] = Color.green;
        colorsGreen[3] = new Color(0, 201, 87, 1);
        colorsGreen[4] = new Color(144, 238, 63, 1);
        colorsGreen[5] = new Color(50, 205, 63, 1);

        gameObject.GetComponent<Renderer>().material.color = colorsGreen[Random.Range(0, colorsGreen.Length)];

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            gameObject.GetComponent<Renderer>().material.color = colorsGreen[Random.Range(0, colorsGreen.Length)];

        }

        // gameObject.GetComponent<Renderer>().material.color = new Color(189, 252, 201);

    }
}
