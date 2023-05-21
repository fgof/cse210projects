using System;
class Animation
{
    public Animation()
    {
    }
    public void CountDown(int duration)
    {
        int time = duration;
        while (time > 0)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;

        }
   
    }
    public void InitialCountDown()
    {

        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
   
    }
}