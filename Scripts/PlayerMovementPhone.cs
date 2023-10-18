using UnityEngine;

public class PlayerMovementPhone : MonoBehaviour
{
    public float forwardForce = 2500f;
    public float sideWayForce = 50f;
    public Rigidbody rb;
    
    void FixedUpdate()
    {       
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x > (Screen.width / 2))
            {
                rb.AddForce(sideWayForce / 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (touch.position.x < (Screen.width / 2))
            {
                rb.AddForce(-sideWayForce / 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
}
}