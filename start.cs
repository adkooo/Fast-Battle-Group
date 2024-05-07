using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    private float timer = 0f;
    public float changeInterval = 50f; // تعیین فاصله زمانی بین تغییر صفحه

    void Update()
    {
        timer += Time.deltaTime;

        // اگر زمان مساوی یا بیشتر از فاصله زمانی مورد نظر بود
        if (timer >= changeInterval)
        {
            // تغییر به سین دوم
            SceneManager.LoadScene("menu");

            // تنظیم مجدد تایمر
            timer = 0f;
        }
    }
}
