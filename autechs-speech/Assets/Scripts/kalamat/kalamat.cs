using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kalamat : MonoBehaviour
{
    public GameObject number1;
    public GameObject number2;
    public GameObject number3;
    public GameObject number4;
    public GameObject number5;
    public GameObject number6;
    public GameObject number7;
    public GameObject number8;
    public GameObject number9;
    public GameObject number10;
    public GameObject win;
    public AudioSource correct;
    public Text TextofPic;
    public string[] result;
    private string response;
    private int number=1;

    void Start()
    {
        //GameObject.Find("Text").GetComponent<Text>().text = "You need to be connected to Internet";

    }

    void onActivityResult(string recognizedText)
    {
        char[] delimiterChars = { '~' };
        result = recognizedText.Split(delimiterChars);

        //You can get the number of results with result.Length
        //And access a particular result with result[i] where i is an int
        //I have just assigned the best result to UI text
        GameObject.Find("TextofResult").GetComponent<Text>().text = result[0];
        response =result[0];


    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("first_scene");
        }

        
        switch (number)
         {
             case 1:
                 number1.SetActive(true);
                 TextofPic.text = "apple";
                 if (response == "apple")
                 {
                    RhightAwnser();
                 }
             break;

             case 2:
                 number2.SetActive(true);
                TextofPic.text = "train";
                if (response == "train")
                 {
                    RhightAwnser();
                 }
             break;

            case 3:
                number3.SetActive(true);
                TextofPic.text = "chocolate";
                if (response == "chocolate")
                {
                    RhightAwnser();
                }
             break;

            case 4:
                number4.SetActive(true);
                TextofPic.text = "bear";
                if (response == "bear")
                {
                    RhightAwnser();
                }
             break;

            case 5:
                number5.SetActive(true);
                TextofPic.text = "truck";
                if (response == "truck")
                {
                    RhightAwnser();
                }
            break;

            case 6:
                number6.SetActive(true);
                TextofPic.text = "parrot";
                if (response == "parrot")
                {
                    RhightAwnser();
                }
            break;

            case 7:
                number7.SetActive(true);
                TextofPic.text = "bread";
                if (response == "bread")
                {
                    RhightAwnser();
                }
            break;

            case 8:
                number8.SetActive(true);
                TextofPic.text = "soda";
                if (response == "soda")
                {
                    RhightAwnser();
                }
                break;

            case 9:
                number9.SetActive(true);
                TextofPic.text = "door";
                if (response == "door")
                {
                    RhightAwnser();
                }
                break;

            case 10:
                number10.SetActive(true);
                TextofPic.text = "frog";
                if (response == "frog")
                {
                    RhightAwnser();
                }
                break;

        }

        if (number >= 11) number = 1;

    
    }
    
    public void RhightAwnser()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("pics");
        foreach (GameObject disable in gameObjectArray)
        {
            disable.SetActive(false);
        }
        StartCoroutine(Right());
        response = "";
        number++;
    }
        IEnumerator Right()
    {
        if(!correct.isPlaying) correct.Play();
        win.SetActive(true);
        yield return new WaitForSeconds(1f);
        win.SetActive(false);
        if (!correct.isPlaying) correct.Play();
    }
    
}
