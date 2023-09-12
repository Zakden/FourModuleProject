using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckNumber : MonoBehaviour
{
    public Text textResult;
    public InputField myNumber;
    int randNumber;
    void Start()
    {
        randNumber = Random.Range(0, 101);
        textResult.text = "Программа загадала число от 1 до 100 - угадайте";
    }
    
    public void onClick()
    {
        if (myNumber.text == "")
        {
            textResult.text = "Введите корректное число";
        }
        else if (int.Parse(myNumber.text) == randNumber)
        {
            textResult.text = "Ура! Вы угадали. Загаданное число " + randNumber;
        }
        else if(int.Parse(myNumber.text) > randNumber) 
        {
            textResult.text = "Загаднное число меньше";
        }
        else if (int.Parse(myNumber.text) < randNumber)
        {
            textResult.text = "Загаднное число больше";
        }
    }
}
