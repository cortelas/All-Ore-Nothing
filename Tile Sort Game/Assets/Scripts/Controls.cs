using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody2D box;
    public Vector3 boxLocation;
    public float halfHeight ;
    public float halfWidth ;
    public float spawnCountdown;
    public float minSpawnTime;
    public float maxSpawnTime;
    public float spawnWidth;
    //public GameObject[] gems; //sets array of gem objects
    //int randomGem;

	//Variables for manipulating spawn-rate (Option 1)
	public const float SPAWNTIMECUTOFF = 0.25f;
	public int NumBoxesUntilIncrease;
	public const float SPAWNTIMEDECREMENT = 0.15f;
	//Option 2 Variables
	public float TimeSinceIncrease;

	// Spawns box
	void SpawnBox()
    {
        boxLocation = new Vector3(Random.Range(-spawnWidth, spawnWidth), halfHeight * 2, 0);
        Instantiate(box, boxLocation, Quaternion.identity);
        //randomGem = Random.Range(0, gems.Length); //animation for gems
        //Instantiate(gems[randomGem], boxLocation, Quaternion.identity);
    }

    // Use this for initialization
    void Start()
    {

        TimeSinceIncrease = 0;
		NumBoxesUntilIncrease = 50; //Rather Low, for testing purposes
        minSpawnTime = 1;
        maxSpawnTime = 3;
        halfHeight = Camera.main.orthographicSize;
        halfWidth = Camera.main.aspect * halfHeight;
        spawnCountdown = Random.Range(minSpawnTime, maxSpawnTime);
        spawnWidth = halfWidth * 4/5;
    }



    // Update is called once per frame
    void Update()
    {


        // Spawns on timer
        spawnCountdown -= Time.deltaTime;
		TimeSinceIncrease += Time.deltaTime;

		//Option 1: Every X boxes increase the rate at which the boxes spawn. (to a limit)
		/*if (NumBoxesUntilIncrease <= 0) //Good for Non-linear rate increase
		{
			if (minSpawnTime > SPAWNTIMECUTOFF)
			{
				minSpawnTime -= SPAWNTIMEDECREMENT / 2;
			}
			if (maxSpawnTime > (maxSpawnTime - SPAWNTIMECUTOFF))
			{
				maxSpawnTime -= SPAWNTIMEDECREMENT;
			}
			NumBoxesUntilIncrease = 50; //As the rate of gem spawns increases, so does the rate of increasing their spawns.
            Debug.Log("Spawn Rate Increase");
		}*/
		//Option 2: Every X seconds increase the rate at which boxes spawn.
		if (TimeSinceIncrease >= 15) //Good for Linear rate increase
		{
			if (minSpawnTime > SPAWNTIMECUTOFF)
			{
				minSpawnTime -= SPAWNTIMEDECREMENT / 2;
			}
			if (maxSpawnTime > maxSpawnTime - SPAWNTIMECUTOFF)
			{
				maxSpawnTime -= SPAWNTIMEDECREMENT;
			}
			TimeSinceIncrease = 0f;
            Debug.Log("Spawn Rate Increase");
		}


		if (spawnCountdown < 0)
        {
            SpawnBox();
            Debug.Log("Spawn-Gem");
            spawnCountdown = Random.Range(minSpawnTime, maxSpawnTime);
			//NumBoxesUntilIncrease--;
        }


    }
}
