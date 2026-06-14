using UnityEngine;
using TMPro;

public class VictoryManager : MonoBehaviour
{
    public static VictoryManager Instance;

    public GameObject victoryText;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowVictory()
    {
        victoryText.SetActive(true);
    }
}
