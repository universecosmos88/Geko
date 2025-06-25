using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    float angleX;
    float angleY;
    public float rotSpeed = 200;

    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        angleX += my * rotSpeed * Time.deltaTime;
        angleY += mx * rotSpeed * Time.deltaTime;

        // X축 회전 각도를 제한 (예: -45도 ~ 45도)
        angleX = Mathf.Clamp(angleX, -45, 45);

        Vector3 angle = new Vector3(-angleX, angleY, 0);
        transform.eulerAngles = angle;
    }
}