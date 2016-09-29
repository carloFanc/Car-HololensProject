using UnityEngine;

public class ExpandCommands : MonoBehaviour
{
    bool editing = false;
    void Start()
    {

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
        }
        if (!TapToPlaceParent.placing)
        {
            SpatialMapping.Instance.DrawVisualMeshes = false;
        }

        GameObject.Find("Menu").transform.FindChild("Resize Four Directions").gameObject.GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("Menu").transform.FindChild("Resize Four Directions").gameObject.GetComponent<SphereCollider>().enabled = true;
        GameObject.Find("Menu").transform.FindChild("Rotate").gameObject.SetActive(true);
        GameObject.Find("Menu").transform.FindChild("Expand").gameObject.SetActive(false);
        GameObject.Find("Menu").transform.FindChild("RotateChild").gameObject.SetActive(false);
        GameObject.Find("Menu").transform.FindChild("ExpandChild").gameObject.SetActive(true);

    }
}