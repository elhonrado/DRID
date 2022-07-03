using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;

    void Update()
    {
        score.SetText((player.position.z+5.0).ToString("0"));
    }
}