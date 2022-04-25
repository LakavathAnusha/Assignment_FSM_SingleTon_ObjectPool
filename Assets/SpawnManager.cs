using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    float time;
    public Transform ground;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        time = time + Time.deltaTime;
        if (time > 3f)
        {
            // GameObject temp=Instantiate(ObjectPoolScript.instance.GetObjectsFromPool("Asteroid"),new Vector3(Random.Range(-8.0f, 8f),4f,0f),Quaternion.identity);
            GameObject enemy = PoolScript.instance.GetObjectsFromPool("enemy");
            if (enemy != null)
            {
                enemy.transform.position = new Vector3(Random.Range(-8.0f, 8f), 2f, Random.Range(-5f,5f));
                enemy.SetActive(true);
            }
            time = 0;
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
           // playerHealth--;
            collision.gameObject.SetActive(false);
           // print("player Health Dec:" + playerHealth);

        }
    }
}