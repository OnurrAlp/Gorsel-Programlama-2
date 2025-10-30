using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player; // oyuncu karakterinin ekrandaki konumu
    public Vector3 offset = new Vector3(0, 45, -45); // oyuncu ve kamera arasýndaki mesafe

    private void LateUpdate()
    {
            transform.position = player.position + offset; // bu scriptin baðlý oldugu nesnenin konumu, oyuncuya ve mesafeye göre güncelle
    }
}
