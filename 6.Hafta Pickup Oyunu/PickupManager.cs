using System.Runtime.CompilerServices;
using UnityEngine;

// toplanabilir kapsülleri rastgele pozisyonlarda oluþturur

public class PickupManager : MonoBehaviour
{

    public GameObject pickup; // doðacak kapsül nesnesi
    public GameObject ground; // zemin nesnesi
    public int amount; // doðacak kapsül sayýsý

    private void Start()
    {/// zemin boyutunu al , Plane nesnesi 10 birimlik karelerden oluþtuðu için ölçeði 10 ile çarparak boyutuna ulaþtýk
        float groundSizeX = ground.transform.localScale.x * 10f;
        float groundSizeZ = ground.transform.localScale.z * 10f;

        for(int i = 0; i<amount; i++)
        {
            float randomX = Random.Range(-groundSizeX / 2f, groundSizeX / 2f) - 1;
            float randomZ = Random.Range(-groundSizeZ / 2f, groundSizeZ / 2f) - 1; //alanýn dýsýna cýkmamasý icin -1 ekledik
            Vector3 randomPosition = new Vector3(randomX, 3f, randomZ);
            Instantiate(pickup, randomPosition, Quaternion.identity); // kapsülü belirlenen rastgele pozisyona oluþtur
        }

}

}


