using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50f; // hareket h�z�
    Rigidbody rb;

    ScoreManager scoreManager;
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Scriptin ba�l� oldu�u nesnenin Rigidbody companentini al
            scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void FixedUpdate()
    {
            float moveX = Input.GetAxis("Horizontal"); // yatay eksende hareket girdisi
            float moveZ = Input.GetAxis("Vertical"); // dikey eksende hareket girdisi

            Vector3 movement = new Vector3(moveX, 0f, moveZ); // Oyuncunun gitmek istedigi y�n� belirle
            rb.AddForce(movement * moveSpeed); // Rigidbody'ye gitmek istenilen y�nde kuvvet uygula b�ylece hareket etmesini sa�la
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup")) // e�er �arp���lan nesne "Pickup" tagine sahipse
        {
            Destroy(other.gameObject); // �arp���lan kaps�l nesnesini yok et
            scoreManager.CollectPickup(); // Skor y�neticisindeki puan toplama fonksiyonunu �a��r
        }
    }

}
