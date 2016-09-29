using UnityEngine;

public class undo2 : MonoBehaviour
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
        
        GameObject.Find("Menu").transform.FindChild("ExpandChild").gameObject.SetActive(false);
        GameObject.Find("Menu").transform.FindChild("Expand").gameObject.SetActive(true);

    }
}