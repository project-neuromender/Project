using UnityEngine;
using Valve.VR;



public class Belt : MonoBehaviour
{
   // [Range(0.5f, 0.75f)]
   public float height = 0.0f;

   // private Transform head = null;

    public Transform table ;

    private void Start()
    {
       
       // head = SteamVR_Render.Top().head;
    }

    private void Update()
    {
        PositionUnderHead();
        RotateWithHead();
    }

    private void PositionUnderHead()
    {
        Vector3 adjustedHeight = table.localPosition;
        adjustedHeight.y = Mathf.Lerp(0.0f, adjustedHeight.y, height);

        transform.localPosition = adjustedHeight;
    }

    private void RotateWithHead()
    {
        Vector3 adjustedRotation = table.localEulerAngles;
        adjustedRotation.x = 0;
        adjustedRotation.z = 0;

        transform.localEulerAngles = adjustedRotation;

    }
}
