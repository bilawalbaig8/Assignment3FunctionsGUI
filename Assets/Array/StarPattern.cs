using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class StarPattern : MonoBehaviour
{
    public TMP_InputField row;
    public TMP_InputField pattern;
    public TMP_Text output;

    // Start is called before the first frame update

    void starPattern()
    {
        int rowInt;
        int.TryParse(row.text, out rowInt);

        string patternBuilder = "";

        for (int i = 1; i < rowInt + 1 ; i++)
        {
            for (int j = 0; j < rowInt - i; j++)
            {
                patternBuilder += " ";
            }
            for (int k = 0; k < i; k++)
            {
                patternBuilder += pattern.text;
            }

            patternBuilder += "\n";
        }
        output.text = patternBuilder;
    }

    public void onGenerateClick()
    {
        starPattern();
    }

    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
