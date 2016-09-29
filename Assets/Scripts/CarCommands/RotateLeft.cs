using UnityEngine;
using System.Collections;

public class RotateLeft : MonoBehaviour
{
    //static public bool backLeft = false;
     
     
    void OnSelect()
    {
            //backLeft=true;
            var Car = GameObject.Find("MURCIELAGO");
            Car.transform.Rotate(0, 200 * Time.deltaTime, 0);
        
    }
}
