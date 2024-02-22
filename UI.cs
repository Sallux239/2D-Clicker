using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI instance;
    public GameObject.panel;
    public Text scoreText;
    public Text defeatText;
    public Text victoryText;

    void Awake()
    {
        singleton = this;
    }

    public static void ShowVictoryPanel()
    {
        singleton.panel.SetAcive(true);
        singleton.victoryText.gameObject.SetActive(true);
        singleton.panelScoreText.tex = Player.score.ToString();
    }
    public static void ShowDefeatPanel()
    {
        singleton.panel.SetAcive(true);
        singleton.defeatText.gameObject.SetActive(true);
        singleton.panelScoreText.tex = Player.score.ToString();
    }
    public void OnClickrestart()
    {
        Player.Restart();
    }
}
