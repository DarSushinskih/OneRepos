using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1 : MonoBehaviour
{ 
    public Text  prov;
    public Text[] text = new Text[8];
    public int[] result = new int[6];
    public GameObject image;
    public GameObject image1;
    public GameObject image2;
    public bool isUncorr = false;
    
    public int health;
    public int numberOfLives;
    public Image[] lives;
    public Sprite fullLive;
    public Sprite empptyLive;
    public bool isGameOver = false;
    private void Start()
    {
         
        Rnd();
        image.SetActive(false);
        image1.SetActive(false);
        image2.SetActive(false);

      
    }

    private void Update()
    {
        if (health < 0)
        {
            isGameOver = true;
            image2.SetActive(true);
        }

        if (health > numberOfLives)
        {
            health = numberOfLives;
        }

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLive;
            }
            else
            {
                lives[i].sprite = empptyLive;
            }
            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }

    public void Rnd()
    {
        text[3].text = (Random.Range(1, 6)).ToString();
        text[5].text = (Random.Range(1, 6)).ToString();
    }
    public void Summa()
    {

        for (int i = 0; i <= 5; i++)
        {
            result[i] = (int.Parse(text[i].text) + int.Parse(text[i + 1].text) + int.Parse(text[i + 2].text));
        }
    }
    public void Vvod()
    {
        for (int i = 0; i <= 7; i++)
        {
            if (0 > int.Parse(text[i].text) || int.Parse(text[i].text) > 6)
            {
                prov.text = "Введите число из допустимого диапазона!!! ";
                isUncorr = true;
                health = health - 1;
                return;
            }
            else
            {
                isUncorr = false;
                prov.text = "";
            }
        }
    }
    public void Prov()
    {
        for (int i = 1; i < 5; i++)
        {
            if (result[i] == result[i - 1] | result[i] == result[i + 1])
            {
                isUncorr = true;
                prov.text += "Выполните условие";
               
                health = health - 1;

                // Debug.Log(health);
                return;
            }
        }
    }


    public void Proverka()
    {
        prov.text = "";
        Vvod();
        Summa();
        Prov();
   
      

        if (!isUncorr)
        {
            if (result[0] == 10 | result[1] == 10 | result[2] == 10 | result[3] == 10 | result[4] == 10 | result[5] == 10)
            {
                image1.SetActive(true);
            }
            else
            {
                image.SetActive(true);
                health = health - 1;
            }
        }

    }

    public void Knopka()
    {
        image.SetActive(false);
    }
   
}

