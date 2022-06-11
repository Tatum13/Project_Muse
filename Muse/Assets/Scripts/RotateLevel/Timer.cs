using System.Collections;
using System.Collections.Generic;
using System;

public class Timer
{
    private float time;
    private float endTime;

    public float Percentage
    {
        get { return (float) Math.Min(time / endTime, 1f); }
    }

    public Timer(float stopTime)
    {
        endTime = stopTime;
        time = 0;
    }
    public void Reset()
    {
        time = 0;
    }
    public bool Update(float deltaTime)
    {
        time += deltaTime;
        if(time >= endTime)
        {
            return true;
        }
        return false;
    }
}
