using UnityEngine;

public class CarCommandsPlus : MonoBehaviour
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
 

    }
}