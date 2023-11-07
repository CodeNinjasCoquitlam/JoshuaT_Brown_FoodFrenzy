using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    [System.Serializable]
    public struct ButtonPlayerPerfs
    {
        public GameObject gameObject;
        public string playerPerfKey;
    }
    public ButtonPlayerPerfs[] buttons;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
