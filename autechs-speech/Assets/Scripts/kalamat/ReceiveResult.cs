using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveResult : MonoBehaviour
{

    public Text NumberText;
    public Text ResponseText;
    private string[] response;
    private int responseInt;
    int x = 0;
    void Start()
    {
        //GameObject.Find("Text").GetComponent<Text>().text = "You need to be connected to Internet";
        x = Random.Range(0, 100);
        NumberText.text = x.ToString();
    }

    void onActivityResult(string recognizedText)
    {
        char[] delimiterChars = { '~' };
        string[] result = recognizedText.Split(delimiterChars);

        //You can get the number of results with result.Length
        //And access a particular result with result[i] where i is an int
        //I have just assigned the best result to UI text
        GameObject.Find("Text").GetComponent<Text>().text = result[0];
        responseInt = int.Parse(result[0]);
        /* if (result[0] == "book")
         {

         }*/

    }

    // Update is called once per frame
    void Update()
    {
        
        if (x == responseInt)
        {
            StartCoroutine(Right());


            // ResponseText.text = responseInt.ToString();
            // responseInt = -1;
        }
        else 
        {
            ResponseText.text = "-";
        }
    }
    IEnumerator Right()
    {
        ResponseText.text = "true";
        yield return new WaitForSeconds(1.5f);
        x = Random.Range(0, 100);
        NumberText.text = x.ToString();
    }
}
 