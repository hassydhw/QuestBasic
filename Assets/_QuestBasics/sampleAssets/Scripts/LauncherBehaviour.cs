using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LauncherBehaviour : MonoBehaviour
{
    [SerializeField] private Scene [] _scenes;
    [SerializeField] private Dropdown dropdown;
    private int sceneIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _scenes.Length; i++)
        {
            string pathToScene = SceneUtility.GetScenePathByBuildIndex(i+1);
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(pathToScene);
            Debug.Log(sceneName);            
            dropdown.options.Add(new Dropdown.OptionData { text = sceneName });
        }
        dropdown.RefreshShownValue();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDropdownValueChanged(int newValue)
    {
        sceneIndex = newValue;
    }
    
    
    public void OnSceneChangeButtonPressed()
    {
        SceneManager.LoadSceneAsync(_scenes[sceneIndex].handle);
    }
    
    
    
}
