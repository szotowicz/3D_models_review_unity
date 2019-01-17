using UnityEngine;

public class SetLight : MonoBehaviour
{
    private readonly float RotationSpeed = 50.0f;
    private float rotation = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            rotation += RotationSpeed * Time.deltaTime;
            Vector3 currentPos = gameObject.transform.localEulerAngles;
            transform.localEulerAngles = new Vector3(rotation, currentPos.y, currentPos.z);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rotation -= RotationSpeed * Time.deltaTime;
            Vector3 currentPos = gameObject.transform.localEulerAngles;
            transform.localEulerAngles = new Vector3(rotation, currentPos.y, currentPos.z);
        }
    }
}