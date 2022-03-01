
---


# <p dir="rtl">
فيديوهات الدرس</p>




* 
[التصادم](https://www.youtube.com/watch?v=HK504TCQ68s&list=PL_gewShnRvv_n0U2MPdkUsMqsX4_KxYHW&index=19)

---


# <p dir="rtl">
شرح الدرس </p>




* اضافة متغيرين SerializedField من نوع Float للتحكم بسرعة المركبة

    ```
[SerializeField] float rotateSpeed = 5f;
[SerializeField] float thrustSpeed = 5f;
```


* يجب استخدام قيمة المتغير الذي تم تعريفه مسبقاً بدالة  rotat & thrust

        ```
void Rotate () {
...
		if (Input.GetKey (KeyCode.A)) {
transform.Rotate (Vector3.forward * rotateSpeed);
		}
		else
		    if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (-Vector3.forward *  rotateSpeed);
		    }
	    }

void Thrust () {
			if (Input.GetKey (KeyCode.Space)) {
			    rb.AddRelativeForce (Vector3.up*thrustSpeed);
			    if (!audioSource.isPlaying) {
				audioSource.PlayOneShot (mainEngine);
			    }
			}
			    else {
				audioSource.Stop ();
			    }
			}
```


* يجب اضافة دالة OnCollisionEnter()

    ```
 void OnCollisionEnter(Collision collision){
		switch (collision.gameObject.tag) {
		case "Friendly":
		    print ("No problem");
		    break;
		case "Finish":
		    print ("You win!");
		    break;
		default:
		    break;
		}
}

```




---

**[Github](https://github.com/kuwaitcodes/gamedev-c4-cw)**

<p dir="rtl">
<strong>تمرين</strong> </p>




* 
اضف متغيرين serializedfield من نوع float لسرعة الصاروخ وسرعة الإلتفاف واستخدامهم بالأماكن المناسبة


* 
قم بإضافة مكان النهاية للهبوط وبعض المعوقات بالمرحلة


* 
قم بإضافة


    *  Tag: Friendly
    * Tag: Finish



* 
اضف دالة OnCollisionEnter() وأضف اللازم داخل الدالة 
