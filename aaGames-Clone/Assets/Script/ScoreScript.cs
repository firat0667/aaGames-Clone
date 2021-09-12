using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int PinCount = 0;
    public TextMeshProUGUI text;
    void Start()
    {
        PinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PinCount.ToString();
    }
}
