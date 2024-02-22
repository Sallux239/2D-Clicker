using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int score = 0;
    public static List<Square> squares;

    public static void Defeat()
    {
        score = 0;
    }

    void Awake()
    {
        squares = new List<Square>();
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (squares.Count == 0)
        {
            Victory();
        }
    }

    public static void Defeat()
    {
        UI.ShowDefeatPanel();
        score = 0;
    }

    public static void Victory()
    {
        UI.ShowVictoryPanel();
    }

    public static void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
