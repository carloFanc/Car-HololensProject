using UnityEngine;

public class ExplodeHood : MonoBehaviour
{

    public GameObject Hood;
    public GameObject HoodCarbon;
    public static bool tap;

    void Start()
    {
        Hood = GameObject.Find("Hood");
        HoodCarbon = GameObject.Find("Hood Carbon");
        tap = false;
    }
    void Update()
    {

    }
    void OnSelect()
    {
        Hood.GetComponent<Animator>().enabled = true;
        HoodCarbon.GetComponent<Animator>().enabled = true;
        tap = !tap;
        if (tap == true)
        {
            Hood.GetComponent<Animator>().Play("HoodOutAnimation");
            HoodCarbon.GetComponent<Animator>().Play("HoodCarbonOutAnimation");
        }
        else if (HoodCarbon.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("HoodCarbonOutAnimation"))
        {
            Hood.GetComponent<Animator>().Play("HoodInAnimation");
            HoodCarbon.GetComponent<Animator>().Play("HoodCarbonInAnimation");
        }
    }
}