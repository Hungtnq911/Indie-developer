using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletBar : MonoBehaviour
{
    public Slider slider;

    

    public void SetMaxBullet(int bullet)
    {
        slider.maxValue = bullet;
        slider.value = bullet;

    }

    public void Setbullet(int bullet)
    {
        slider.value = bullet;

    }
}
