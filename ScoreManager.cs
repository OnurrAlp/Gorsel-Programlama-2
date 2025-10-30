using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public GameObject GameOverScreen; // oyun bitti ekraný
    PickupManager pickups; // sahnedeki kapsüllere referans
    int totalPickups; // sahnede olan kapsül sayýsý
    int score = 0; // skor sayacý   

    private void Start()
    {
        pickups = FindFirstObjectByType<PickupManager>();
        totalPickups = pickups.amount;  
        UpdateScore();
    }

    public void CollectPickup()
    {
        score++;
        UpdateScore();
        if(score >= totalPickups)
        {
            GameOverScreen.SetActive(true); // oyun bitti ekranýný göster
            Time.timeScale = 0f; // Oyunu durdur
        }

    }
    public void UpdateScore()
    {
        scoreText.text = "Skor: " + score.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
