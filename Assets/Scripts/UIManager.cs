using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI crystalText;
    public TextMeshProUGUI livesText;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateCrystalText(int amount)
    {
        crystalText.text = "Cristais: " + amount;
    }

    public void UpdateLivesText(int amount)
    {
        livesText.text = "Vidas: " + amount;
    }
}