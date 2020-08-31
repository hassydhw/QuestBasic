using UnityEngine;

public class ControllerInput : MonoBehaviour
{

    public TextMesh buttonTouchText;
    public TextMesh buttonDownText;
    public TextMesh stickValueText;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckButtonDown();
        CheckButtonTouch();
        CheckStickValue();

        Debug.Log(buttonDownText.text);
    }

    private void CheckStickValue()
    {
        stickValueText.text = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).ToString()
        + "\n"
        + OVRInput.Get(OVRInput.RawAxis2D.RThumbstick).ToString();

    }

    private void CheckButtonDown()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            //Aボタンを押した際の処理
            buttonDownText.text = "A pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            //Bボタンを押した際の処理
            buttonDownText.text = "B pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            //Xボタンを押した際の処理
            buttonDownText.text = "X pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            //Yボタンを押した際の処理
            buttonDownText.text = "Y pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            //右人差し指トリガーを押した際の処理
            buttonDownText.text = "R_index pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            //右中指トリガーを押した際の処理
            buttonDownText.text = "R_hand_trigger pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            //左人差し指トリガーを押した際の処理
            buttonDownText.text = "L_index pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
        {
            //左中指トリガーを押した際の処理
            buttonDownText.text = "L_hand_trigger pressed";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstick))
        {
            //左スティックを押した際の処理
            buttonDownText.text = "L_StickButton pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstick))
        {
            //右スティックを押した際の処理
            buttonDownText.text = "R_StickButton pressed";
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Start))
        {
            //左のスタートボタン
            buttonDownText.text = "Start Button pressed";
        }
    }

    private void CheckButtonTouch()
    {
        if (OVRInput.Get(OVRInput.RawTouch.A))
        {
            //Aボタンをタッチした際の処理         
            buttonTouchText.text = "A touching";
        }
        if (OVRInput.Get(OVRInput.RawTouch.B))
        {
            //Bボタンをタッチした際の処理         
            buttonTouchText.text = "B touching";
        }
        if (OVRInput.Get(OVRInput.RawTouch.X))
        {
            //Xボタンをタッチした際の処理         
            buttonTouchText.text = "X touching";
        }
        if (OVRInput.Get(OVRInput.RawTouch.Y))
        {
            //Yボタンをタッチした際の処理         
            buttonTouchText.text = "Y touching";
        }

        if (OVRInput.Get(OVRInput.RawTouch.LIndexTrigger))
        {
            buttonTouchText.text = "L_index touching";
        }
        if (OVRInput.Get(OVRInput.RawTouch.LThumbstick))
        {
            buttonTouchText.text = "L_Stick touching";
        }

        if (OVRInput.Get(OVRInput.RawTouch.RIndexTrigger))
        {
            buttonTouchText.text = "R_index touching";
        }
        if (OVRInput.Get(OVRInput.RawTouch.RThumbstick))
        {
            buttonTouchText.text = "R_Stick touching";
        }
    }
}
