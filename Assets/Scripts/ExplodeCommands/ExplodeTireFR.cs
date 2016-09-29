using UnityEngine;

public class ExplodeTireFR : MonoBehaviour
{

    public GameObject TireFR; 
    public static bool tap;

    void Start()
    {
        TireFR = GameObject.Find("TireFR"); 
        tap = false;
    }
    void Update()
    {

    }
    void OnSelect()
    {
        TireFR.GetComponent<Animator>().enabled = true; 
        tap = !tap;
        if (tap == true)
        {
            TireFR.GetComponent<Animator>().Play("TireFROutAnimation");
        }
        else if (TireFR.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("TireFROutAnimation"))
        {
            TireFR.GetComponent<Animator>().Play("TireFRInAnimation"); 
        }
    }
}