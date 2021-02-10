using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame(){
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void OnPressHigher(){
        min = guess;
        NewGuess();
    }
    
    public void OnPressLower(){
        max = guess;
        NewGuess();
    }

    void NewGuess(){
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
