using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float playerSpeed;
    public float health;
    public Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        transform.Translate(inputX * playerSpeed * Time.deltaTime, 0f, inputY * playerSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject tempBullet = PoolScript.instance.GetObjectsFromPool("Bullet");
            if (tempBullet != null)
            {
                tempBullet.transform.position = this.transform.position + offSet;
                // transform.Translate(0f, 0f, 1f);
                tempBullet.SetActive(true);
            }
            //Instantiate(bulletPrefab, transform.position + offSet, Quaternion.identity);
        }
    }
    
}
