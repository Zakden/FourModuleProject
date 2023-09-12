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
        textResult.text = "��������� �������� ����� �� 1 �� 100 - ��������";
    }
    
    public void onClick()
    {
        if (myNumber.text == "")
        {
            textResult.text = "������� ���������� �����";
        }
        else if (int.Parse(myNumber.text) == randNumber)
        {
            textResult.text = "���! �� �������. ���������� ����� " + randNumber;
        }
        else if(int.Parse(myNumber.text) > randNumber) 
        {
            textResult.text = "��������� ����� ������";
        }
        else if (int.Parse(myNumber.text) < randNumber)
        {
            textResult.text = "��������� ����� ������";
        }
    }
}
