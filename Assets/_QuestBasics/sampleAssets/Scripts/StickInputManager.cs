using UnityEngine;

public class StickInputManager : MonoBehaviour
{
    public OVRInput.RawAxis2D myStick;
    public TextMesh inputCommandTextmesh;
    public TextMesh stickValueTextmesh;

    Vector2 myStickValue;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myStickValue = OVRInput.Get(myStick);

        if (myStickValue.x > 0.5 && -0.5 < myStickValue.y && myStickValue.y < 0.5)
        {
            //右方向
            inputCommandTextmesh.text = "right";
        }
        else if (myStickValue.x < -0.5 && -0.5 < myStickValue.y && myStickValue.y < 0.5)
        {
            //左方向
            inputCommandTextmesh.text = "left";
        }
        else if (myStickValue.y > 0.5 && -0.5 < myStickValue.x && myStickValue.x < 0.5)
        {
            //上方向
            inputCommandTextmesh.text = "up";
        }
        else if (myStickValue.y < -0.5 && -0.5 < myStickValue.x && myStickValue.x < 0.5)
        {
            //下方向
            inputCommandTextmesh.text = "down";
        }
        else
        {
            //四方向に該当しない場合
            inputCommandTextmesh.text = "no direction";
        }

        stickValueTextmesh.text = myStickValue.ToString();
    }
}
