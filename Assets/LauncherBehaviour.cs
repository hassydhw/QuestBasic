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
        for (int i = 0; i < _scenes.Length; i++)
        {
            string pathToScene = SceneUtility.GetScenePathByBuildIndex(i+1);
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(pathToScene);
            Debug.Log(sceneName);            
        }
        
        // foreach (var eachScene in _scenes)
        // {
        //     Debug.Log(eachScene.buildIndex);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSceneChangeButtonPressed()
    {
        SceneManager.LoadSceneAsync(_scenes[10].handle);
    }
    
    
    
}
