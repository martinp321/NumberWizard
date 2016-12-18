using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{


    public Text text;


    // Use this for initialization
    void Start()
    {
        text.text = "guessing a number..";
    }

    int min = 1;
    int max = 1000;
    int guess = 500;

    // Update is called once per frame
    void Update()
    {


        text.text = "Your number is " + guess.ToString();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
        }

        guess = (max + min) / 2;

    }
}

