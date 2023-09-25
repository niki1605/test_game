using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    public Joystick joystick;


    private Rigidbody2D rb;
    public float speed = 8f;
    private Vector2 moveVector;
    public static  bool facingRight = true;
    public Image[] image;
    public  Sprite[] slotinventory;
    public GameObject deleteslot;
    public GameObject[] buttslotpan;
    public Sprite slotnull;
    public Animator animpl;

    public GameObject not_armed;
    public GameObject armed_AK;
    public GameObject armed_makarov;
    public GameObject[] textbullet;
    public Transform shotpoint;
    public GameObject bull;
    public GameObject buttfire;

    

    public int number_bull;
    public Text[] number_bull_text;

    public GameObject Gameoverpan;

    public Image hpbar;
    public float hp=1f;

    int i=0;
    int f1=0;
    int f2=0;
    int f3=0;
    int fobj=0;
    int fobj2 = 0;
    int fobj3 = 0;
    int fslotbut1;
    int fslotbut2;
    int fslotbut3;
    int fslotbut4;
    int fslotbut5;
    public void butslot1()
    {
        fslotbut1 = 1;
        fslotbut2 = 0;
        fslotbut3 = 0;
        fslotbut4 = 0;
        fslotbut5 = 0;
        deleteslot.SetActive(true);

        if (image[0].sprite == slotinventory[0])
        {
            not_armed.SetActive(false);
            armed_AK.SetActive(true);
            armed_makarov.SetActive(false);
            buttfire.SetActive(true);
        }

        if (image[0].sprite == slotinventory[1])
        {

            not_armed.SetActive(false);
            armed_AK.SetActive(false);
            armed_makarov.SetActive(true);
            buttfire.SetActive(true);
        }
    }

    public void butslot2()
    {
        fslotbut1 =0;
        fslotbut2 = 1;
        fslotbut3 = 0;
        fslotbut4 = 0;
        fslotbut5 = 0;
        deleteslot.SetActive(true);

        if (image[1].sprite == slotinventory[0])
        {
            not_armed.SetActive(false);
            armed_AK.SetActive(true);
            armed_makarov.SetActive(false);
            buttfire.SetActive(true);
        }

        if (image[1].sprite == slotinventory[1])
        {

            not_armed.SetActive(false);
            armed_AK.SetActive(false);
            armed_makarov.SetActive(true);
            buttfire.SetActive(true);
        }

    }

    public void butslot3()
    {
        fslotbut1 = 0;
        fslotbut2 = 0;
        fslotbut3 = 1;
        fslotbut4 = 0;
        fslotbut5 = 0;
        deleteslot.SetActive(true);

        if (image[2].sprite == slotinventory[0])
        {
            not_armed.SetActive(false);
            armed_AK.SetActive(true);
            armed_makarov.SetActive(false);
            buttfire.SetActive(true);
        }

        if (image[2].sprite == slotinventory[1])
        {

            not_armed.SetActive(false);
            armed_AK.SetActive(false);
            armed_makarov.SetActive(true);
            buttfire.SetActive(true);
        }

    }

    public void butslot4()
    {
        fslotbut1 = 0;
        fslotbut2 = 0;
        fslotbut3 = 0;
        fslotbut4 = 1;
        fslotbut5 = 0;
        deleteslot.SetActive(true);

        if (image[3].sprite == slotinventory[0])
        {
            not_armed.SetActive(false);
            armed_AK.SetActive(true);
            armed_makarov.SetActive(false);
            buttfire.SetActive(true);
        }

        if (image[3].sprite == slotinventory[1])
        {

            not_armed.SetActive(false);
            armed_AK.SetActive(false);
            armed_makarov.SetActive(true);
            buttfire.SetActive(true);
        }
    }

    public void butslot5()
    {
        fslotbut1 = 0;
        fslotbut2 = 0;
        fslotbut3 = 0;
        fslotbut4 = 0;
        fslotbut5 = 1;
        deleteslot.SetActive(true);

        if (image[4].sprite == slotinventory[0])
        {
            not_armed.SetActive(false);
            armed_AK.SetActive(true);
            armed_makarov.SetActive(false);
            buttfire.SetActive(true);
        }

        if (image[4].sprite == slotinventory[1])
        {

            not_armed.SetActive(false);
            armed_AK.SetActive(false);
            armed_makarov.SetActive(true);
            buttfire.SetActive(true);
        }
    }


    public void buttdeleteslot()
    {
        
    

        if (fslotbut1==1)
        {

            if (image[0].sprite != slotinventory[2] )
            {

                not_armed.SetActive(true);
                armed_AK.SetActive(false);
                armed_makarov.SetActive(false);
                buttfire.SetActive(false);
            }else
            {
                textbullet[0].SetActive(false);
                i = 0;
                

            }

            if (image[0].sprite == slotinventory[0])
            {
                i = 0;
                f1 = 0;
            }

            if (image[0].sprite == slotinventory[1])
            {
                i = 0;
                f2 = 0;
            }

            image[0].sprite = slotnull;

            fslotbut1 = 0;
        }

        if (fslotbut2 == 1)
        {
    if ( image[1].sprite != slotinventory[2] )
            {

                not_armed.SetActive(true);
                armed_AK.SetActive(false);
                armed_makarov.SetActive(false);
                buttfire.SetActive(false);
            }
            else
            {
                i = 0;
                textbullet[1].SetActive(false);
                

            }

            if (image[1].sprite == slotinventory[0])
            {
                i = 0;
                f1 = 0;
            }

            if (image[1].sprite == slotinventory[1])
            {

                i = 0;
                f2 = 0;
            }



            image[1].sprite = slotnull;

        

            fslotbut2 = 0;

        }
        if (fslotbut3 == 1)
        {
if ( image[2].sprite != slotinventory[2])
            {

                not_armed.SetActive(true);
                armed_AK.SetActive(false);
                armed_makarov.SetActive(false);
                buttfire.SetActive(false);
            }
            else
            {
                i = 0;
                textbullet[2].SetActive(false);
                

            }

            if (image[2].sprite == slotinventory[0])
            {
                i = 0;
                f1 = 0;
            }

            if (image[2].sprite == slotinventory[1])
            {
                i = 0;
                f2 = 0;
            }
            image[2].sprite = slotnull;
            
            fslotbut3 = 0;
        }
        if (fslotbut4 == 1)
        {
  if (image[3].sprite != slotinventory[2])
            {

                not_armed.SetActive(true);
                armed_AK.SetActive(false);
                armed_makarov.SetActive(false);
                buttfire.SetActive(false);
            }
            else
            {
                i = 0;
                textbullet[3].SetActive(false);
               

            }

            if (image[3].sprite == slotinventory[0])
            {
                i = 0;
                f1 = 0;
            }

            if (image[3].sprite == slotinventory[1])
            {
                i = 0;
                f2 = 0;
            }

            image[3].sprite = slotnull;
          
            fslotbut4 = 0;
        }
        if (fslotbut5 == 1)
        {
        if (image[4].sprite != slotinventory[2])
            {

                not_armed.SetActive(true);
                armed_AK.SetActive(false);
                armed_makarov.SetActive(false);
                buttfire.SetActive(false);
            }
            else
            {
                i = 0;
                textbullet[4].SetActive(false);
                

            }

            if (image[4].sprite == slotinventory[0])
            {
                i = 0;
                f1 = 0;
            }

            if (image[4].sprite == slotinventory[1])
            {
                i = 0;
                f2 = 0;
            }
            image[4].sprite = slotnull;
    
            fslotbut5 = 0;
        }



    }    

    public void buttonfire()
    {
        deleteslot.SetActive(false);
        if(number_bull>0)
        {
Instantiate(bull,shotpoint.position, shotpoint.rotation);
            number_bull--;
        }else
        {

            Debug.Log("нет патронов");

        }
        

    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }


    void Update()
    {


        moveVector.x = joystick.Horizontal;
        moveVector.y = joystick.Vertical;
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);

        if(hp<=0)
        {

            Gameoverpan.SetActive(true);
            Destroy(hpbar);
            Destroy(gameObject);


        }
        

       if(moveVector.x==0)
        {

            animpl.SetBool("walk", false);

        }
        else
        {

deleteslot.SetActive(false);
animpl.SetBool("walk", true);
        }

        if (!facingRight && moveVector.x < 0)
        {
            Flip();
        }
        else if (facingRight && moveVector.x > 0)
        {
            Flip();
        }

        if (f3 == 1)
        {
            number_bull += 5;
            f3 = 0;
        }





        number_bull_text[0].text = number_bull.ToString();
        number_bull_text[1].text = number_bull.ToString();
        number_bull_text[2].text = number_bull.ToString();
        number_bull_text[3].text = number_bull.ToString();
        number_bull_text[4].text = number_bull.ToString();
        hpbar.fillAmount = hp;
    }


    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }


    


    private void OnTriggerEnter2D(Collider2D other)
    {

       if (other.CompareTag("zombie"))
        {
            hp -= 0.2f;
        }

            if (other.CompareTag("ak47"))
        {
            if(f1==0)
            {
                
                while (fobj != 1)
                {

                    if (image[i].sprite == slotnull)
                    {
   
                            buttslotpan[i].SetActive(false);
                        textbullet[i].SetActive(false);
                        image[i].sprite = slotinventory[0];
                        f1 = 1;
            Destroy(other.gameObject);
                        fobj = 1;
                        
                       
                    }
                  i++;  

                    if(i>=4)
                    {
                        i = 0;
                        fobj = 1;

                    }

                }
                

            }
           

            }


        if (other.CompareTag("Makarov"))
        {
            if (f2 == 0)
            {
                
                while (fobj2 != 1)
                {

                    if (image[i].sprite == slotnull)
                    {
                        buttslotpan[i].SetActive(false);
                        textbullet[i].SetActive(false);
                        image[i].sprite = slotinventory[1];
                        
                        f2 = 1;
                        Destroy(other.gameObject);
                        fobj2 = 1;
                    }
                    i++;

                    if (i >= 4)
                    {
                        i = 0;
                        fobj2 = 1;

                    }

                }

            }
        }

        if (other.CompareTag("patron"))
        {

            while (fobj3 != 1)
                {

                    if (image[i].sprite == slotnull )
                    {
                        buttslotpan[i].SetActive(false);
                        textbullet[i].SetActive(true);
                        image[i].sprite = slotinventory[2];
                    
                        
                        
                        fobj3 = 1;
                    }
                    i++;

                    if (i >= 4)
                    {
                        i = 0;
                        fobj3 = 1;

                    }

                }
            f3 = 1;
             Destroy(other.gameObject);
                

           

            


        }

    }

}
