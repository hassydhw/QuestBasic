using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (OVRInput.Get(OVRInput.RawButton.LThumbstick) && 
            OVRInput.GetDown(OVRInput.RawButton.RThumbstick))
        {
            //左スティックをおしつつ、右ステック押し込んだときに、ランチャーにもどる
            SceneManager.LoadSceneAsync(0);
        }
    }
}
