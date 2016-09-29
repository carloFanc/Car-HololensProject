using UnityEngine;

public class ExpandPlus : MonoBehaviour
{
    bool editing = false;
    Vector3 temp;
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


        var Car = GameObject.Find("MURCIELAGO");
        Car.transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);

    }
}