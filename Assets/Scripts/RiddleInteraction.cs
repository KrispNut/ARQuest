using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleInteraction : MonoBehaviour
{
    public GameObject Riddle1;
    public GameObject Riddle2;
    public GameObject Riddle3;
    public Button button1;
    public Button button2;
    public Button button3;

    private void Start() 
    {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
    }
    private void Update()
    {
        // Check for touch input
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast to check if the touch hits the prefab
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Riddle_1"))
                {
                    Destroy(hit.collider.gameObject);

                    button1.gameObject.SetActive(true);
                }
                else if (hit.collider.gameObject.CompareTag("Riddle_2"))
                {
                    Destroy(hit.collider.gameObject);

                    button2.gameObject.SetActive(true);
                }
                else if (hit.collider.gameObject.CompareTag("Riddle_3"))
                {
                    Destroy(hit.collider.gameObject);

                    button3.gameObject.SetActive(true);
                }
            }
        }
    }
}
