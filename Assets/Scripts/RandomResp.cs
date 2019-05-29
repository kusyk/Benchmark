using UnityEngine;
using System.Collections;

public class RandomResp : MonoBehaviour {

    public GameObject[] players;
    public Vector3 minLocation;
    public Vector3 maxLocation;
    public int quantity = 100;


    void Awake()
    {
        for (int i = 0; i < quantity; i++)
        {
            foreach (GameObject player in players)
            {
                Instantiate(player,
                            new Vector3(Random.Range(minLocation.x, maxLocation.x),
                                                Random.Range(minLocation.y, maxLocation.y),
                                                Random.Range(minLocation.z, maxLocation.z)),
                            new Quaternion(0, 0, 0, 0));
            }
        }
    }
}