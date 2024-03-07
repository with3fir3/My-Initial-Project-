using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI uiWinner;

    void Start()
    {
        SaveController.Instance.Reset();
        string lastWinner = SaveController.Instance.GetLastWinner();
    
         if (lastWinner != "")
            uiWinner.text = "�ltimo vencedor: " + lastWinner;
        else
            uiWinner.text = "";
    }
       







    



}
