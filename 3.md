
---


# <p dir="rtl">
فيديوهات الدرس</p>




* 
[صوت الصاروخ](https://www.youtube.com/watch?v=5DjxLMdKy-o&list=PL_gewShnRvv_n0U2MPdkUsMqsX4_KxYHW&index=17)

---


# <p dir="rtl">
شرح الدرس </p>




* اضافة متغير من نوع AudioSource ومتغير SerializedField من نوع AudioClip

    ```
AudioSource rocketAudiosource;
[SerializeField] AudioClip mainEngine;
```


* يجب تعيين قيمة للمتغير داخل دالة  start()

        ```
void Start()
    {
        rocketRB = GetComponent<Rigidbody>();
        rocketAudioSource = GetComponent<AudioSource>();
    }
```


* يجب التعديل على دالة ال Thrust() لتشغيل الصوت بشكل مناسب

    ```
 void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Thrusting!");
            rocketRB.AddRelativeForce(Vector3.up * 60);
            if (!rocketAudioSource.isPlaying)
            {
                rocketAudioSource.PlayOneShot(mainEngine);
            }
        }
        else {
            rocketAudioSource.Stop();
        }
    }

```




---

**[Github](https://github.com/kuwaitcodes/gamedev-c4-cw)**

<p dir="rtl">
<strong>تمرين</strong> </p>




* 
قم بزيارة موقع [https://freesound.org/](https://freesound.org/) 


* 
ابحث عن صوت مناسب لإنطلاق الصاروخ وقم بتحميله


* 
أضف Audio Source للصاروخ وقم بكتابة الكود اللازم لتشغيل الصوت
<p dir="rtl">
<strong>Bonus</strong>:</p>




* 
قم بإضافة صوت مناسب يبدأ عند بداية المرحلة
