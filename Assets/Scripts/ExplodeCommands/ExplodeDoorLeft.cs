using UnityEngine;

public class ExplodeDoorLeft : MonoBehaviour
{

    public GameObject DoorL;
    public static bool tap; 

    void Start()
    {
        DoorL = GameObject.Find("DoorLeftComplete");
        tap = false;
    }
    void Update()
    {

    }
    void OnSelect()
    {
        DoorL.GetComponent<Animator>().enabled = true;
        tap = !tap;
        if (tap == true)
        {
            DoorL.GetComponent<Animator>().Play("DoorLeftOutAnimation");
        }
        else if (DoorL.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("DoorLeftOutAnimation"))
        {
            DoorL.GetComponent<Animator>().Play("DoorLeftInAnimation");
        } 
    }
}