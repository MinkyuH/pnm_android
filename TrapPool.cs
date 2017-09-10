using UnityEngine;
using System.Collections;

public class TrapPool : MonoBehaviour {

    public int trappoolsize = 5;
    public GameObject trapPrefab;
    private GameObject[] traps;
    private float timeSinceLastSpawn;
    public float spawnrate = 4f;
    public float trapmin = -1f;
    public float trapmax = 0f;
    private float spawnPosition = 10f;
    private int currenttrap = 0;

    private Vector2 ObjectPoolPosition = new Vector2(-15f, -25f);
	// Use this for initialization
	void Start () {
        traps = new GameObject[trappoolsize];
        for (int i = 0; i < trappoolsize; i++)
        {
            traps[i] = (GameObject) Instantiate(trapPrefab, ObjectPoolPosition, Quaternion.identity);
        }  
	}
	
	// Update is called once per frame
	void Update () 
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (GameController.instance.gameOver == false && timeSinceLastSpawn >= spawnrate)
        {
            timeSinceLastSpawn = 0;
            float SpawnYPosition = Random.Range(trapmin,trapmax);
            traps[currenttrap].transform.position = new Vector2(spawnPosition, SpawnYPosition);
            currenttrap++;
            if (currenttrap >= trappoolsize)
            {
                currenttrap = 0;
            }
          
        }
	}
}
