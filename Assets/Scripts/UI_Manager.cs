using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject BackGround;


    void Start()
    {
        DeactivateAllTexts();
    }

    void Update()
    {
        
    }

    public void ShowText1()
    {
        text1.SetActive(true);
        BackGround.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
    }

    public void ShowText2()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        BackGround.SetActive(true);
        text3.SetActive(false);
    }

    public void ShowText3()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(true);
        BackGround.SetActive(true);
    }

    public void DeactivateAllTexts()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        BackGround.SetActive(false);
    }
}
