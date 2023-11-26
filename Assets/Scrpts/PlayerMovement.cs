using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float FowardForce = 2000f;
    public float SideForce = 500f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, FowardForce * Time.deltaTime);

        // Check for touch input
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            
            if (touch.position.x > Screen.width / 2)
            {
                // Left half of the screen, move left
                rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else
            {
                // Right half of the screen, move right
                rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        // Check for keyboard input
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
