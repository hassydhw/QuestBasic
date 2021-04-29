using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LauncherBehaviour : MonoBehaviour
{
    [SerializeField] private Scene [] _scenes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSceneChangeButtonPressed()
    {
        SceneManager.LoadSceneAsync(_scenes[0].handle);
    }
    
    
    
}
