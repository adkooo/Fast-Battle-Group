using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerA : MonoBehaviour
{
    private Rigidbody2D c;
    public float e;
    public Text g;
    int h = 0;
    public Text j;
    public Text k;


    public AudioClip l;
    public AudioClip r;

    public Sprite newSprite; // عکس جدیدی که می‌خواهید استفاده کنید
    private SpriteRenderer spriteRenderer;
    public Sprite newSpritee;
    int go = 0;

    void Updatee()
    {
        g.text = h.ToString() + " / 42";
        if (h >= 42 && go == 1)
        {
            j.text = "You win the game :)";
        }
    }


    void FixedUpdate()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");
        // c.AddForce(new Vector2(a,b));

        Vector2 d = new Vector2(a, b);

        c.AddForce(d * e);


    }



    void OnTriggerEnter2D(Collider2D f)
    {



        if (f.gameObject.tag == "coin")
        {
            f.gameObject.SetActive(false);

            h++;


            Updatee();

             //gameObject.GetComponent<AudioSource>().clip = l;
            //gameObject.GetComponent<AudioSource>().Play();

            //  g.text = "Katana :" + h.ToString();
        }


        if (f.gameObject.tag == "enemy")
        {
            //gameObject.GetComponent<AudioSource>().clip = l;
           // gameObject.GetComponent<AudioSource>().Play();

            gameObject.SetActive(false);
            don();
        }

        if (f.gameObject.tag == "apple")
        {

            f.gameObject.SetActive(false);

             h = 0;

            Updatee();


        }



        if (f.gameObject.tag == "playerb")
        {

            f.gameObject.SetActive(false);


            spriteRenderer = GetComponent<SpriteRenderer>(); // دریافت SpriteRenderer که می‌خواهیم عکس آن را تغییر دهیم
            if (spriteRenderer != null && newSprite != null)
            {

                 Vector3 newScale = new Vector3(1f, 0.88f, 1f);

                spriteRenderer.sprite = newSprite; // تغییر عکس

                transform.localScale = newScale;
            }
            else
            {
                Debug.LogError("SpriteRenderer or newSprite is not assigned!"); // در صورتی که SpriteRenderer یا عکس جدید تخصیص داده نشده باشد، پیام خطا نمایش داده می‌شود
            }



        }


        if (f.gameObject.tag == "playerc")
        {

            f.gameObject.SetActive(false);


            spriteRenderer = GetComponent<SpriteRenderer>(); // دریافت SpriteRenderer که می‌خواهیم عکس آن را تغییر دهیم
            if (spriteRenderer != null && newSpritee != null)
            {

               // Vector3 newScale = new Vector3(1f, 0.88f, 1f);

                spriteRenderer.sprite = newSpritee; // تغییر عکس

                //transform.localScale = newScale;
            }
            else
            {
                Debug.LogError("SpriteRenderer or newSprite is not assigned!"); // در صورتی که SpriteRenderer یا عکس جدید تخصیص داده نشده باشد، پیام خطا نمایش داده می‌شود
            }
        }



        if (f.gameObject.tag == "go")
        {

           

            go++;

            Updatee();


        }

    }



   



    void don()
    {
        k.text = "! GAME OVER !";
    }

   



    // Start is called before the first frame update
    void Start()
    {



        

        c = GetComponent<Rigidbody2D>();

        Updatee();












        // g.text = "Katana :"  + h.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
