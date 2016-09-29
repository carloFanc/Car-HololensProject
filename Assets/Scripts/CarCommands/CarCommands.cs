using UnityEngine;

public class CarCommands : MonoBehaviour
{
    bool editing = false;
    void Start()
    {
        GameObject.Find("Menu").transform.FindChild("Resize Four Directions").gameObject.GetComponent<SpriteRenderer>().enabled = editing;
        GameObject.Find("Menu").transform.FindChild("Resize Four Directions").gameObject.GetComponent<SphereCollider>().enabled = editing;
        GameObject.Find("Menu").transform.FindChild("Rotate").gameObject.SetActive(editing);
        GameObject.Find("Menu").transform.FindChild("Expand").gameObject.SetActive(editing);
        GameObject.Find("Menu").transform.FindChild("RotateChild").gameObject.SetActive(editing);
        GameObject.Find("Menu").transform.FindChild("ExpandChild").gameObject.SetActive(editing);
    }
    void Update()
    {
         
    }
    void OnSelect()
    {
        editing = !editing;

        if (TapToPlaceParent.move == true)
        {
            TapToPlaceParent.placing = false;
            TapToPlaceParent.move = false;
        }
        if (!TapToPlaceParent.placing)
        {
            SpatialMapping.Instance.DrawVisualMeshes = false;
        }

        GameObject.Find("Menu").transform.FindChild("Resize Four Directions").gameObject.GetComponent<SpriteRenderer>().enabled = editing;
        GameObject.Find("Menu").transform.FindChild("Resize Four Directions").gameObject.GetComponent<SphereCollider>().enabled = editing;
        GameObject.Find("Menu").transform.FindChild("Rotate").gameObject.SetActive(editing);
        GameObject.Find("Menu").transform.FindChild("Expand").gameObject.SetActive(editing);
        GameObject.Find("Menu").transform.FindChild("RotateChild").gameObject.SetActive(false);
        GameObject.Find("Menu").transform.FindChild("ExpandChild").gameObject.SetActive(false);

    }
}