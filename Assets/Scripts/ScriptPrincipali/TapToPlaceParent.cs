using UnityEngine;

public class TapToPlaceParent : MonoBehaviour
{
    public static bool placing = false;
    public static bool move = false;
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // On each Select gesture, toggle whether the user is in placing mode.
        placing = !placing;
         
        // If the user is in placing mode, display the spatial mapping mesh.
        if (placing)
        {
            SpatialMapping.Instance.DrawVisualMeshes = true;
        }
        // If the user is not in placing mode, hide the spatial mapping mesh.
       /* else
        {
            SpatialMapping.Instance.DrawVisualMeshes = false;
        }*/
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the user is in placing mode,
        // update the placement to match the user's gaze.

        if (placing)
        {
            GameObject.Find("Menu").transform.FindChild("Resize Four Directions").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Menu").transform.FindChild("Resize Four Directions").GetComponent<SphereCollider>().enabled = false;
            GameObject.Find("Menu").transform.FindChild("Rotate").gameObject.SetActive(false);
            GameObject.Find("Menu").transform.FindChild("Expand").gameObject.SetActive(false);
            GameObject.Find("Menu").transform.FindChild("RotateChild").gameObject.SetActive(false);
            GameObject.Find("Menu").transform.FindChild("ExpandChild").gameObject.SetActive(false);
 
            // Do a raycast into the world that will only hit the Spatial Mapping mesh.
            var headPosition = Camera.main.transform.position;
            var gazeDirection = Camera.main.transform.forward;
            move = true;
            RaycastHit hitInfo;
            if (Physics.Raycast(headPosition, gazeDirection, out hitInfo,
                30.0f, SpatialMapping.PhysicsRaycastMask))
            {
                // Move this object's parent object to
                // where the raycast hit the Spatial Mapping mesh.
                var Cyl = GameObject.Find("Cylinder");
                var Cursor = GameObject.Find("Cursor");
                var Menu = GameObject.Find("Menu");
                Cyl.transform.parent.position = hitInfo.point;
                Menu.transform.parent.position = hitInfo.point;
                Cursor.transform.parent.position = Cyl.transform.parent.position;
                //this.transform.parent.position = hitInfo.point;

                // Rotate this object's parent object to face the user.
               Quaternion toQuat = Camera.main.transform.localRotation;
                toQuat.x = 0;
                toQuat.z = 0;
                var Car = GameObject.Find("MURCIELAGO");
                Car.transform.parent.rotation = toQuat; 
            }
        }
    }
}