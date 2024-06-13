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
    private int number;

    public string DetermineEvenOdd(int number)
    {
        if (number%2 == 0)
        {
            return "Number is Even";
        }
        else
        {
            return "Number is Odd";
        }
    }

    public bool validateInteger(TMP_InputField userInput)
    {
        bool isInteger = int.TryParse(userInput.text, out number);

        if (!isInteger)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    public string Tenth (int number)
    {
        string[] tenth = { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
        string result = "";
        
        validateInteger(userInput);

        if (number < 100)
        {
            if (number / 10 == 1) { result = tenth[1]; }
            else if (number / 10 == 2) { result = tenth[2]; }
            else if (number / 10 == 3) { result = tenth[3]; }
            else if (number / 10 == 4) { result = tenth[4]; }
            else if (number / 10 == 5) { result = tenth[5]; }
            else if (number / 10 == 6) { result = tenth[6]; }
            else if (number / 10 == 7) { result = tenth[7]; }
            else if (number / 10 == 8) { result = tenth[8]; }
            else if (number / 10 == 9) { result = tenth[9]; }
        }
        else
        {
            result = "Working but wrong";
        }
        return result;
    }

    //public string unit(int number)
    //{
    //    string[] unit = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten","Eleven", "Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Ninteen" };
    //    string result = "";

    //    validateInteger(userInput);

    //    if (number > 20)
    //    {
    //        if (number / 10 == 1) { result = unit[1]; }
    //        else if (number / 10 == 2) { result = unit[2]; }
    //        else if (number / 10 == 3) { result = unit[3]; }
    //        else if (number / 10 == 4) { result = unit[4]; }
    //        else if (number / 10 == 5) { result = unit[5]; }
    //        else if (number / 10 == 6) { result = unit[6]; }
    //        else if (number / 10 == 7) { result = unit[7]; }
    //        else if (number / 10 == 8) { result = unit[8]; }
    //        else if (number / 10 == 9) { result = unit[9]; }
    //    }
    //    else
    //    {
    //        result = "Working but wrong";
    //    }
    //    return result;
    //}

    public void SubmitBtn()
    {
        if (validateInteger(userInput))
        {
            if(number < 1000)
            {
                evenOddResult.text = DetermineEvenOdd(number);
            }
            else
            {
                evenOddResult.text = "Enter a number less than 1000";
            }
            
        }
        else
        {
            evenOddResult.text = "Enter a valid whole number";
        }
       
    }

    public void ConversionBtn()
    {
        numberToTextResult.text = Tenth(number);
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
