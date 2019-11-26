using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1 : MonoBehaviour
{

    [SerializeField] Text otvet, prov;
    [SerializeField] Text[] text = new Text[8];
    [SerializeField] int[] result = new int[6];
    public GameObject image;
    public GameObject image1;

    private void Start()
    {
        Rnd();
        image.SetActive(false);
        image1.SetActive(false);
    }
    public void Rnd()
    {
        text[3].text = (Random.Range(1, 6)).ToString();
        text[5].text = (Random.Range(1, 6)).ToString();
    }
    public void Summa()
    {

        for(int i = 0; i <= 5; i++)
        {
            result[i] = (int.Parse(text[i].text) + int.Parse(text[i + 1].text) + int.Parse(text[i + 2].text));
        }
    }
    public void Vvod()
    {
        for (int i = 0; i <= 7; i++)
        {
            if (0 > int.Parse(text[i].text) || int.Parse(text[i].text) >= 6)
            {
                prov.text = "Введите число из допустимого диапазона!!!";
                return;
            }
        }
    }
    public void Proverka()
    {
        Rnd();
        Vvod();
        Summa();
        
        if (result[0] == 10 | result[1] == 10 | result[2] == 10 | result[3] == 10 | result[4] == 10 | result[5] == 10)
        {
            image1.SetActive(true);
        }
        else
        {
            image.SetActive(true);
        }
    }
    public void Knopka()
    {
        image.SetActive(false);
    }
   
}
