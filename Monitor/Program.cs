﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Monitor
{
    class Program
    {

        static WindowMonitor Monitor;


        static void Main(string[] args)
        {
            
            Monitor = new WindowMonitor("config.json"); 
            Application.Run();
            
        }

        

        
    }
}
