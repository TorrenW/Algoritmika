using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool hasFinished=false;
    private float minutes=0f;
    private float seconds=0f;

    void Update()
    {
        if (hasFinished == true) //игрок на финише?
        {
            //Да
        }
        else 
        {
            //Нет
            seconds += Time.deltaTime;
        }

        if(seconds>=60) //Если секунды = 60
        {
            seconds -=60;
            minutes += 1;
        }
        int m = Mathf.RoundToInt(minutes);
        int s = Mathf.RoundToInt(seconds);

    }
}
