using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BikeSharing.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportEffect(typeof(UnderLineTextEffect),nameof(UnderLineTextEffect))]
namespace BikeSharing.Droid.Effects
{
    public class UnderLineTextEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is TextView label)
                label.PaintFlags |= Android.Graphics.PaintFlags.UnderlineText;
        }

        protected override void OnDetached()
        {

        }
    }
}