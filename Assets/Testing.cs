using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Testing : MonoBehaviour
{

    public TMP_InputField input;
    public TMP_Text result;
    public int number;


    public void Submitbtn()
    {
        result.text = input.text;
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
