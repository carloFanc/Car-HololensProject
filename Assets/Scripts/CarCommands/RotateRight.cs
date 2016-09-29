using UnityEngine;
using System.Collections;

public class RotateRight : MonoBehaviour
{
     //static public bool backRight = false;
    void OnSelect()
    {
      //  backRight=true; 
        var Car = GameObject.Find("MURCIELAGO");
        Car.transform.Rotate(0, -200 * Time.deltaTime, 0);
    }
}
