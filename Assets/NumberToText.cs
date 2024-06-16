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

    bool validateInteger(TMP_InputField userInput)
    {
        return int.TryParse(userInput.text, out number);
    }


    string tenth(int inputNumber)
    {
        string[] ten = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        return ten[inputNumber];
    }

    string unit(int inputNumber)
    {

        string[] units = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" ,
                        "Eleven","Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen","Eighteen", "Nineteen"};
        return units[inputNumber];
    }

    public string numberToWord(int inputNumber)
    {
        string result = "";

        if (inputNumber < 0)
        { return "Use positive values only"; }

        if (inputNumber == 0)
        {      return unit(0);      }


        if (inputNumber >= 100)
        {
            int hundrad = inputNumber / 100;
            result += unit(hundrad) + " Hundrad ";
            inputNumber %= 100;

            if (inputNumber > 0)
            {
                result+=("& ");
            }
        }

        if (inputNumber >= 20)
        {
            int tens = inputNumber / 10;
            result += tenth(tens) + " ";
            inputNumber %= 10;
        }

        if (inputNumber > 0)
        {            result += unit(inputNumber) + " ";        }
        
        return result;
    }
   


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
        if (validateInteger(userInput))
        {
            if (number < 1000)
            {
                numberToTextResult.text = numberToWord(number);
            }
            else
            {
                numberToTextResult.text = "Enter a number less than 1000";
            }
        }
        else
        {
            numberToTextResult.text = "Enter a valid whole number";
        }

    }

}
