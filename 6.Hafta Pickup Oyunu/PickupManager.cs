using System.Runtime.CompilerServices;
using UnityEngine;

// toplanabilir kaps�lleri rastgele pozisyonlarda olu�turur

public class PickupManager : MonoBehaviour
{

    public GameObject pickup; // do�acak kaps�l nesnesi
    public GameObject ground; // zemin nesnesi
    public int amount; // do�acak kaps�l say�s�

    private void Start()
    {/// zemin boyutunu al , Plane nesnesi 10 birimlik karelerden olu�tu�u i�in �l�e�i 10 ile �arparak boyutuna ula�t�k
        float groundSizeX = ground.transform.localScale.x * 10f;
        float groundSizeZ = ground.transform.localScale.z * 10f;

        for(int i = 0; i<amount; i++)
        {
            float randomX = Random.Range(-groundSizeX / 2f, groundSizeX / 2f) - 1;
            float randomZ = Random.Range(-groundSizeZ / 2f, groundSizeZ / 2f) - 1; //alan�n d�s�na c�kmamas� icin -1 ekledik
            Vector3 randomPosition = new Vector3(randomX, 3f, randomZ);
            Instantiate(pickup, randomPosition, Quaternion.identity); // kaps�l� belirlenen rastgele pozisyona olu�tur
        }

}

}


