using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kalamatController : MonoBehaviour
{
    public string[] result;
    private string response;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void firstScene()
    {
        SceneManager.LoadScene("first");
    }
}
