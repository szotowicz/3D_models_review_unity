using UnityEngine;

public class FlyCamera : MonoBehaviour
{
    private readonly float mainSpeed = 0.5f;
    private readonly float camSensitive = 0.25f;
    private Vector3 lastMouse = new Vector3(255.0f, 255.0f, 255.0f);

    void Update()
    {
        if (!Input.GetKey(KeyCode.Q))
        {
            lastMouse = Input.mousePosition - lastMouse;
            lastMouse = new Vector3(-lastMouse.y * camSensitive, lastMouse.x * camSensitive, 0);
            lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
            transform.eulerAngles = lastMouse;
            lastMouse = Input.mousePosition;

            Vector3 possition = GetBaseInput();
            possition *= mainSpeed;

            Vector3 newPosition = transform.position;
            if (Input.GetKey(KeyCode.Space))
            {
                transform.Translate(possition);
            }
            else
            {
                transform.Translate(possition);
                newPosition.x = transform.position.x;
                newPosition.z = transform.position.z;
                transform.position = newPosition;
            }
        }
    }

    private Vector3 GetBaseInput()
    {
        Vector3 direction = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            direction += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector3(1, 0, 0);
        }
        return direction;
    }
}