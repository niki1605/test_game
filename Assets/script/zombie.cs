using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class zombie : MonoBehaviour
{

    public float speed;
    public static int f;
    public static Transform player;
    public Image hpbar;
    public float hp = 1f;
    public Transform pointdrops;
    public GameObject drops;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void FixedUpdate()
    {

        if(f==1)
        {

transform.position = Vector2.MoveTowards(transform.position, player.position, speed);

        }

        
    }


   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpbar.fillAmount = hp;
        if (hp <= 0)
        {
            Instantiate(drops, pointdrops.position, Quaternion.identity);
            Destroy(gameObject);

        }

        if (f == 1)
        {

            if (player.transform.position.x < transform.position.x)
            {
                gameObject.transform.localScale = new Vector3(-1.5f, 1.5f,1);

            }
            else if (player.transform.position.x > transform.position.x)
            {
                gameObject.transform.localScale =new Vector3(1.5f, 1.5f, 1);

            }

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "bull")
        {

            hp -= 0.3f;

        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
f = 1;
        }
            

    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            f = 0;
        }

    }

}
