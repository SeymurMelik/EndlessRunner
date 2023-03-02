using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable, ICollectable
{
    bool isGrounded = false;
    public float speed;

    public int myCoin;


    public GameObject ground1;
    public GameObject ground2;

    // Start is called before the first frame update
    void Start()
    {
        myCoin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("as");
                transform.position = new Vector2(transform.position.x, transform.position.y + 5);
                isGrounded = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = true;
        }
        if (collision.tag == "ground2")
        {
            ground1.transform.position = new Vector3(ground1.transform.position.x + 35, ground1.transform.position.y, ground1.transform.position.z);
        }
        if (collision.tag == "ground1")
        {
            ground2.transform.position = new Vector3(ground2.transform.position.x + 35, ground2.transform.position.y, ground2.transform.position.z);
        }
    }

    public void TakeDamage()
    {
        speed -= 1;
        if (speed <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void CollectCoin(int coin)
    {
        coin++;
        myCoin = coin;
        print(myCoin);
    }
}
