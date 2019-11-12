using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1 : MonoBehaviour
{
    [SerializeField] Text text, text1, text2, text3, text4, text5, text6, text7, otvet, prov;
    int result1;
    int result2;
    int result3;
    int result4;
    int result5;
    int result6;
    // Start is called before the first frame update

   
    
    public void Summa()
    {
        result1 = (int.Parse(text.text) + int.Parse(text1.text) + int.Parse(text2.text));
        result2 = (int.Parse(text1.text) + int.Parse(text2.text) + int.Parse(text3.text));
        result3 = (int.Parse(text2.text) + int.Parse(text3.text) + int.Parse(text4.text));
        result4 = (int.Parse(text3.text) + int.Parse(text4.text) + int.Parse(text5.text));
        result5 = (int.Parse(text4.text) + int.Parse(text5.text) + int.Parse(text6.text));
        result6= (int.Parse(text5.text) + int.Parse(text6.text) + int.Parse(text7.text));
    }
    public void Vvod()
    {
        
        if (0 > int.Parse(text.text) || int.Parse(text.text) > 7)
        {
            prov.text = "Введите число из допустимого диапазона!!!";
        }
       

    }
    public void Proverka()
    {
        Vvod();
        Summa();
        
        if (result1 == 10 || result2 == 10 || result3 == 10 || result4 == 10 || result5 == 10 || result6 == 10)
        {
            otvet.text = "Открыт";
        }
        else
        {
            otvet.text = "Замок закрыт";
        }
       
       
    
           

    }

   
   
}
