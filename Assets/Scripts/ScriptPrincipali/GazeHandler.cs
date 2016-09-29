using UnityEngine;
using System.Collections;

public class GazeHandler : MonoBehaviour {

    private Color startColor;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnGazeEnter()
    {
        var com = GameObject.Find("DoorLeftComplete").GetComponent<Renderer>();
        startColor = com.material.color;
        com.material.color = Color.red;
    }

    void OnGazeLeave()
    {
        var com = GameObject.Find("DoorLeftComplete").GetComponent<Renderer>();
        com.material.color = startColor;
    }
}
