using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{


    public float speed = 5f; // سرعت حرکت
    private Vector3 direction = Vector3.right; // جهت حرکت (محور x)
    private Vector3 initialPosition; // موقعیت اولیه


    void Start()
    {
        // ذخیره موقعیت اولیه
        initialPosition = transform.position;
    }




    void Update()
    {
        // اعمال حرکت به شیء در جهت مشخص شده
        transform.Translate(direction * speed * Time.deltaTime);

        // چک کردن اگر شیء به مرزی از صفحه برسد و جهت حرکت را تغییر دهیم
        if (transform.position.x >= initialPosition.x + 5f)
        {
            direction = Vector3.left;
        }
        else if (transform.position.x <= initialPosition.x - 5f)
        {
            direction = Vector3.right;
        }
    }

}

