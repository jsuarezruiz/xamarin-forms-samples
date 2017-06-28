﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace LayoutOptionsDemo.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("LayoutOptionsDemo");
            window.Show();
            Gtk.Application.Run();
        }
    }
}