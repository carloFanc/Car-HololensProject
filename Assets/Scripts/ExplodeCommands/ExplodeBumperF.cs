using UnityEngine;

public class ExplodeBumperF : MonoBehaviour
{

    public GameObject BumperF;
    public static bool tap;

    void Start()
    {
        BumperF = GameObject.Find("BumperF");
        tap = false;
    }
    void Update()
    {

    }
    void OnSelect()
    {
        BumperF.GetComponent<Animator>().enabled = true;
        tap = !tap;
        if (tap == true)
        {
            BumperF.GetComponent<Animator>().Play("BumperFOutAnimation");
        }
        else if (BumperF.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("BumperFOutAnimation"))
        {
            BumperF.GetComponent<Animator>().Play("BumperFInAnimation");
        }
    }
}