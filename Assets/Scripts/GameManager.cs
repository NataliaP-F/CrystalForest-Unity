using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int crystals = 0;
    public int lives = 3;

    public AudioSource audioSource;
    public AudioClip crystalSound;
    public AudioClip damageSound;

    private bool canTakeDamage = true;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UIManager.Instance.UpdateLivesText(lives);
    }

    public void CollectCrystal()
    {
        crystals++;

        audioSource.PlayOneShot(crystalSound);

        Debug.Log("Cristais: " + crystals);

        UIManager.Instance.UpdateCrystalText(crystals);
    }

    public void TakeDamage()
    {
        if (!canTakeDamage)
            return;

        canTakeDamage = false;

        lives--;
        
        audioSource.PlayOneShot(damageSound);

        UIManager.Instance.UpdateLivesText(lives);

        Debug.Log("Vidas: " + lives);

        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }

        Invoke(nameof(ResetDamage), 1f);
    }

    private void ResetDamage()
    {
        canTakeDamage = true;
    }
}