using Android.Runtime;
using System;
using TipCalc.UWP;

namespace TipCalc.Droid
{
    [global::Android.App.ApplicationAttribute(
        Label = "@string/app_name",
        LargeHeap = true,
        HardwareAccelerated = true,
        Theme = "@style/AppTheme"
    )]
    public class Application : Windows.UI.Xaml.NativeApplication
    {
        public Application(IntPtr javaReference, JniHandleOwnership transfer)
            : base(new App(), javaReference, transfer)
        {
        }
    }
}

