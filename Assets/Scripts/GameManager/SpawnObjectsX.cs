using UnityEngine;

public class SpawnObjectsX : MonoBehaviour
{
    public GameObject[] animalsPrefabs;

    private float spawnX = 14f;
    private float spawnLeftRightX = 17f;


    private float maxRightUp = 14f;
    private float maxRightDown = 7f;

   

    private void Start()
    {
        InvokeRepeating("SpawnPrefabsX", 2, 2);
        InvokeRepeating("SpawnPrefabsRightZ", 2, 2);
        InvokeRepeating("SpawnPrefabsLeftZ", 2, 2);
    }




    private void SpawnPrefabsX()
    {
        int index = Random.Range(0, animalsPrefabs.Length);
        Instantiate(animalsPrefabs[index], SpawnX(), animalsPrefabs[index].transform.rotation);
    }
    private Vector3 SpawnX()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnX, -spawnX), 0, 20);
        return spawnPos;
    }



    private void SpawnPrefabsRightZ()
    {
        Vector3 rotate = new Vector3(0, -90, 0);
        int index = Random.Range(0, animalsPrefabs.Length);
        Instantiate(animalsPrefabs[index], spawnPositionRightZ(), Quaternion.Euler(rotate));
    }


    private Vector3 spawnPositionRightZ()
    {
        Vector3 spawnPosZRight = new Vector3(spawnLeftRightX, 0, Random.Range(maxRightUp, -maxRightDown));
        return spawnPosZRight;
    }





    private void SpawnPrefabsLeftZ()
    {
        Vector3 rotate = new Vector3(0, 90, 0);
        int index = Random.Range(0, animalsPrefabs.Length);
        Instantiate(animalsPrefabs[index], spawnPositionLeftZ(), Quaternion.Euler(rotate));
    }


    private Vector3 spawnPositionLeftZ()
    {
        Vector3 spawnPosZRight = new Vector3(-spawnLeftRightX, 0, Random.Range(maxRightUp, -maxRightDown));
        return spawnPosZRight;
    }
}




