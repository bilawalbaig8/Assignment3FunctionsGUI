using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberToText : MonoBehaviour
{

    public TMP_InputField userInput;
    public TMP_Text evenOddResult;
    public TMP_Text numberToTextResult;

    public void submit()
    {
        evenOddResult.text = "HelloWorld";
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
