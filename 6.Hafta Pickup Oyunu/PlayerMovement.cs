using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50f; // hareket hýzý
    Rigidbody rb;

    ScoreManager scoreManager;
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Scriptin baðlý olduðu nesnenin Rigidbody companentini al
            scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void FixedUpdate()
    {
            float moveX = Input.GetAxis("Horizontal"); // yatay eksende hareket girdisi
            float moveZ = Input.GetAxis("Vertical"); // dikey eksende hareket girdisi

            Vector3 movement = new Vector3(moveX, 0f, moveZ); // Oyuncunun gitmek istedigi yönü belirle
            rb.AddForce(movement * moveSpeed); // Rigidbody'ye gitmek istenilen yönde kuvvet uygula böylece hareket etmesini saðla
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup")) // eðer çarpýþýlan nesne "Pickup" tagine sahipse
        {
            Destroy(other.gameObject); // çarpýþýlan kapsül nesnesini yok et
            scoreManager.CollectPickup(); // Skor yöneticisindeki puan toplama fonksiyonunu çaðýr
        }
    }

}
