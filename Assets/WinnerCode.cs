using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinnerCode : MonoBehaviour
{
    public TextMeshProUGUI winner;

    // Start is called before the first frame update
    void Start()
    {
        winner.text = "Player "+PlayerPrefs.GetInt("winner") + " won";
    }

}
