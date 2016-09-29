using UnityEngine;

public class ExplodeDoorRight : MonoBehaviour
{

    public GameObject DoorR;
    public static bool tap;

    void Start()
    {
        DoorR = GameObject.Find("DoorRightComplete");
        tap = false;
    }
    void Update()
    {

    }
    void OnSelect()
    {
        DoorR.GetComponent<Animator>().enabled = true;
        tap = !tap;
        if (tap == true)
        {
            DoorR.GetComponent<Animator>().Play("DoorRightOutAnimation");
        }
        else if (DoorR.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("DoorRightOutAnimation"))
        {
            DoorR.GetComponent<Animator>().Play("DoorRightInAnimation");
        }
    }
}