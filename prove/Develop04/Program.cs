using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        BaseActivity baseActivity = new BaseActivity("Breathing", "This is the breathing activity . . .");
        
        
        baseActivity.DisplayGreeting();

        int response = 0;
        while(response != 4)
        {
            Thread.Sleep(1000);
            response = menu.DisplayMenu();
            
        }
    }
}