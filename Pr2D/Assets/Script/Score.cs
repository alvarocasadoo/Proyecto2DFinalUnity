using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int totalScore;

    public TMP_Text text;

    private void Update()
    {
        text.text = "Puntuación: "+totalScore;
    }



}
