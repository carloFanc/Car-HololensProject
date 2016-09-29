using UnityEngine;

public class ExplodeHlightR : MonoBehaviour
{

    public GameObject HlightRG;
    public GameObject HlightR;
    public static bool tap;

    void Start()
    {
        HlightR = GameObject.Find("HLightR");
        HlightRG = GameObject.Find("HLightRG");
        tap = false;
    }
    void Update()
    {

    }
    void OnSelect()
    {
        HlightR.GetComponent<Animator>().enabled = true;
        HlightRG.GetComponent<Animator>().enabled = true;
        tap = !tap;
        if (tap == true)
        {
            HlightRG.GetComponent<Animator>().Play("HlightRGOutAnimation");
            HlightR.GetComponent<Animator>().Play("HlightROutAnimation");
        }
        else if (HlightR.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("HlightROutAnimation"))
        {
            HlightRG.GetComponent<Animator>().Play("HlightRGInAnimation");
            HlightR.GetComponent<Animator>().Play("HlightRInAnimation");
        }
    }
}