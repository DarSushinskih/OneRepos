using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

namespace Tests
{
    public class Test1
    {
        level1 l1;

        [SetUp]
        public void Test1SimplePasses()
        {
            GameObject canvas = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Canvas"));
            l1 = canvas.GetComponent<level1>();

            l1.text[0] = l1.gameObject.transform.Find("InputField").transform.Find("Text10").gameObject.GetComponent<Text>();
            l1.text[1] = l1.gameObject.transform.Find("InputField (1)").transform.Find("Text11").gameObject.GetComponent<Text>();
            l1.text[2] = l1.gameObject.transform.Find("InputField (2)").transform.Find("Text12").gameObject.GetComponent<Text>();
            l1.text[3] = l1.gameObject.transform.Find("Text13").gameObject.GetComponent<Text>();
            l1.text[4] = l1.gameObject.transform.Find("InputField (4)").transform.Find("Text14").gameObject.GetComponent<Text>();
            l1.text[5] = l1.gameObject.transform.Find("Text15").gameObject.GetComponent<Text>();
            l1.text[6] = l1.gameObject.transform.Find("InputField (6)").transform.Find("Text16").gameObject.GetComponent<Text>();
            l1.text[7] = l1.gameObject.transform.Find("InputField (7)").transform.Find("Text17").gameObject.GetComponent<Text>();

            l1.image = l1.gameObject.transform.GetComponentInChildren<Image>().gameObject;
            l1.image1 = l1.gameObject.transform.GetComponentInChildren<Image>().gameObject;
            l1.image2 = l1.gameObject.transform.GetComponentInChildren<Image>().gameObject;

            l1.prov = l1.gameObject.transform.Find("InputField").transform.Find("Text10").gameObject.GetComponent<Text>();

            l1.gameObject.transform.Find("InputField").GetComponent<InputField>().text = 1.ToString();
            l1.gameObject.transform.Find("InputField (1)").GetComponent<InputField>().text = 1.ToString();
            l1.gameObject.transform.Find("InputField (2)").GetComponent<InputField>().text = 1.ToString();
            l1.gameObject.transform.Find("InputField (4)").GetComponent<InputField>().text = 1.ToString();
            l1.gameObject.transform.Find("InputField (6)").GetComponent<InputField>().text = 8.ToString();
            l1.gameObject.transform.Find("InputField (7)").GetComponent<InputField>().text = 1.ToString();

        }

        [TearDown]
        public void Tear()
        {
            Object.Destroy(l1.gameObject);
        }

        [UnityTest]
        public IEnumerator Test1Random()
        {
            l1.Rnd();
            yield return new WaitForSeconds(0.1f);

            Assert.AreNotEqual(l1.text[3].text, "");
        }

        [UnityTest]
        public IEnumerator Test1Sum()
        {
            l1.Rnd();

            l1.Summa();
            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(l1.result[0], 3);
        }

        [UnityTest]
        public IEnumerator Test1HP()
        {

            yield return new WaitForSeconds(0.1f);
            Assert.AreNotEqual(l1.health, "");
           
        }

        [UnityTest]
        public IEnumerator Test1Uncorr()
        {
            l1.Vvod();
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual(l1.isUncorr, true);

        }

        [TearDown]
        public void Tear1()
        {
            Object.Destroy(l1.gameObject);
        }
    }
}
