using System;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    private string code;

    public string Code
    {
        get { return code; }
    }


    // This method is called by VendingButton
    public void HandleButtonPressed(string buttonValue)
    {
        switch (buttonValue)
        {
            case "0":
                AppendCharacterToCode("0");
                break;

            case "1":
                AppendCharacterToCode("1");
                break;

            case "2":
                AppendCharacterToCode("2");
                break;

            case "3":
                AppendCharacterToCode("3");
                break;

            case "4":
                AppendCharacterToCode("4");
                break;

            case "5":
                AppendCharacterToCode("5");
                break;

            case "6":
                AppendCharacterToCode("6");
                break;

            case "7":
                AppendCharacterToCode("7");
                break;

            case "8":
                AppendCharacterToCode("8");
                break;

            case "9":
                AppendCharacterToCode("9");
                break;

            case "clear":
                ClearCode();
                break;

            case "submit":
                HandleSubmit();
                break;

            default:
                // Code to handle unknown button press
                break;
        }
    }

    // Used to add a digit to the code
    private void AppendCharacterToCode(string character)
    {
        if (character.Length == 1)
        {
            code += character;
        }
        else
        {
            Debug.LogError("Error : trying to append string which length != 1 ON FAIT QUOI POUR LES ERREURS ?????? JSP");
        }
    }

    // Called when pressing de "clear" button
    private void ClearCode()
    {
        code = "";
    }

    // Called when pressing the "submit" button
    private void HandleSubmit()
    {
        switch (code)
        {
            case "12344786248612696243542":
                // idk
                break;

            default:
                Debug.Log(code);
                break;
        }
    }
}
