using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;
//using Microsoft.SPOT.Bitmap;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace HelloMonitor
{
    public partial class Program
    {
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            Bitmap image1 = new Bitmap(Resources.GetBytes(Resources.BinaryResources.bmp_load), Bitmap.BitmapImageType.Bmp);

            while (true)
            {
                //displayTE35.BacklightEnabled = true;
                displayTE35.SimpleGraphics.DisplayImage(image1, 0, 0);
                displayTE35.SimpleGraphics.AutoRedraw = false;

                Thread.Sleep(30);
            }

            Debug.Print("Program Started");
        }
    }
}
