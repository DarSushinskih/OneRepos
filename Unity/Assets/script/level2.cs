using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level2 : MonoBehaviour
{
    [SerializeField] Text[] text = new Text[9];

    void Start()
    {
       

        text[0].text = (Random.Range(0, 9)).ToString();
        text[1].text = (Random.Range(0, 9)).ToString();
        text[2].text = (Random.Range(0, 9)).ToString();

        text[3].text = (Random.Range(0, 9)).ToString();
        text[4].text = (Random.Range(0, 9)).ToString();
        text[5].text = (Random.Range(0, 9)).ToString();

        text[6].text = text[2].text;
        text[7].text = text[5].text;
        text[8].text = (Random.Range(0, 9)).ToString();

        text[9].text = (Random.Range(0, 9)).ToString();
        text[10].text = (Random.Range(0, 9)).ToString();
        text[11].text = (Random.Range(0, 9)).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
