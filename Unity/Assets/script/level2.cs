using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level2 : MonoBehaviour
{
    [SerializeField] Text[] text = new Text[9];
    [SerializeField] Text[] input = new Text[3];
    [SerializeField] Text zadanie, text1;
    public GameObject image;
    public GameObject image1;
    public GameObject image2;
    public GameObject bottem;


    public int health;
    public int numberOfLives;
    public Image[] lives;
    public Sprite fullLive;
    public Sprite empptyLive;

    void Start()

    {
        image.SetActive(false);
        image1.SetActive(false);
        image2.SetActive(false);
        bottem.SetActive(true);

        text[0].text = (Random.Range(0, 9)).ToString();
        text[1].text = (Random.Range(0, 9)).ToString();
        text[2].text = (Random.Range(0, 9)).ToString();

        text[3].text = (Random.Range(0, 9)).ToString();
        text[4].text = (Random.Range(0, 9)).ToString();
        text[5].text = (Random.Range(0, 9)).ToString();

        text[6].text = text[2].text;
        text[7].text = (Random.Range(0, 9)).ToString();
        text[8].text = (Random.Range(0, 9)).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= 1; i++)
        {
            if (text[i].text == text[i + 1].text || text[i].text == text[i + 2].text)
            {
                text[i].text = (Random.Range(0, 9)).ToString();
                Debug.Log(text[i].text);
            }
        }

        for (int i = 3; i <= 4; i++)
        {
            if (text[i].text == text[i + 1].text || text[i].text == text[i + 2].text)
            {
                text[i].text = (Random.Range(0, 9)).ToString();
                Debug.Log(text[i].text);
            }
            if (text[i].text == text[2].text)
            {
                text[i].text = (Random.Range(0, 9)).ToString();
                Debug.Log(text[i].text);
            }
            if (text[2].text == text[5].text)
            {
                text[5].text = (Random.Range(0, 9)).ToString();
                Debug.Log(text[5].text);
            }
        }


        if (text[7].text == text[0].text || text[7].text == text[1].text || text[7].text == text[3].text || text[7].text == text[4].text || text[7].text == text[8].text)
        {
            text[7].text = (Random.Range(0, 9)).ToString();
            Debug.Log(text[7].text);
        }


        for (int i = 7; i < 9; i++)
        {
            if (text[i].text == text[6].text || text[i].text == text[5].text)
            {
                text[i].text = (Random.Range(0, 9)).ToString();
                Debug.Log(text[i].text);
            }

        }

        if (health < 0)
        {
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

    public void Proverka()
    {

        if (input[0].text == text[7].text || input[1].text == text[5].text || input[2].text == text[2].text)
        {
            image.SetActive(true);
        }
        else
        {
            image1.SetActive(true);
            health = health - 1;
        }

    }
    public void Podskazka()
    {
        text1.text = "Попытка №4";
        zadanie.text = "Все цифры не правильные.";

        health = health - 1;

        text[9].text = (Random.Range(0, 9)).ToString();
        text[10].text = (Random.Range(0, 9)).ToString();
        text[11].text = (Random.Range(0, 9)).ToString();

        bottem.SetActive(false);

        for (int i = 9; i <= 11; i++)
        {
            if (text[i].text == text[6].text & text[i].text == text[5].text & text[i].text == text[7].text)
            {
                text[i].text = (Random.Range(0, 9)).ToString();
                Debug.Log(text[i].text);
            }
        }
            
    }

      
    public void Knopka()
    {
        image1.SetActive(false);
    }



}





