using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrayIteration : MonoBehaviour
{
    public TMP_InputField userInput;
    public TMP_Text output;

    private int[] arrayOfInt;

    void Start()
    {

    }

    void InputToArrayInt()
    {
        // Split user input by commas and convert to integers
        string[] inputStrings = userInput.text.Split(',');
        arrayOfInt = new int[inputStrings.Length];

        for (int i = 0; i < inputStrings.Length; i++)
        {
            if (int.TryParse(inputStrings[i], out int num))
            {
                arrayOfInt[i] = num;
                output.text = arrayOfInt[i].ToString();
            }
        }
    }

    void FindRepetition()
    {
        InputToArrayInt();
        bool isFound = false;

        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            for (int j = i + 1; j < arrayOfInt.Length; j++)
            {
                if (arrayOfInt[j] == arrayOfInt[i])
                {
                    output.text = "Repetition found";
                    isFound = true;
                    break; // Break out of the inner loop
                }
            }

            if (isFound)
            {
                break; // Break out of the outer loop
            }
        }

        if (!isFound)
        {
            output.text = "No repetition found";
        }
    }


    public void OnRepeatBtn()
    {
        InputToArrayInt();
        FindRepetition();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
