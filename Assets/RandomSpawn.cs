using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private Enemy obj;
    float RandX;
    Vector3 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    [SerializeField] private Transform _player;
    float nextSpawn = 0.0f;
    private GameObject parent;
    void Start()
    {
        parent = new GameObject("Enemys");
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    private IEnumerator Spawn()
    {
        while(true)
        {
            RandX = Random.Range(1f, 799f);
            whereToSpawn = new Vector3(Random.Range(1f, 799f), Random.Range(25f, 101f), Random.Range(1f, 799f));
            var enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            enemy.transform.parent = parent.transform;
            enemy.Init(_player);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
