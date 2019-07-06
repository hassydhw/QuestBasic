using UnityEngine;

public class StickMove : MonoBehaviour
{
    public GameObject moveTargetObj;
    public GameObject rotationRefObj;

    public float forwardSpeed;
    public float rotationSpeed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            MoveForward();
        }
        else
        {
            Vector2 touchPadPt = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
            if (touchPadPt.y > 0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
            {
                //上方向
                ////前進
                //moveTargetObj.transform.position += (rotationRefObj.transform.rotation * Vector3.forward).normalized * forwardSpeed * Time.deltaTime;
                MoveForward();
            }
            if (touchPadPt.x > 0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
            {
                //右方向
                //右回りに回転
                moveTargetObj.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            }
            if (touchPadPt.x < -0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
            {
                //左方向
                //左回りに回転
                moveTargetObj.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            }
            //if (touchPadPt.y < -0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
            //{
            //    //下方向
            //    dpadInputMesh.text = "down";
            //    //今回は移動には使わない、後退するという実装もありかも
            //}


        }


    }

    private void MoveForward()
    {
        //前進
//        moveTargetObj.transform.position += (rotationRefObj.transform.rotation * Vector3.forward).normalized * forwardSpeed * Time.deltaTime;

        //移動にはy軸の回転だけを使う
        Vector3 HMDDir = rotationRefObj.transform.rotation.eulerAngles;
        Quaternion moveRotation = Quaternion.Euler(0, HMDDir.y, 0);
        moveTargetObj.transform.position += (moveRotation * Vector3.forward).normalized * forwardSpeed * Time.deltaTime;
    }
}
