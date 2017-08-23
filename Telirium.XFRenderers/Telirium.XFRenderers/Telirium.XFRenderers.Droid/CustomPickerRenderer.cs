using System.ComponentModel;
using Android.Graphics.Drawables;
using Telirium.XFRenderers;
using Telirium.XFRenderers.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]

namespace Telirium.XFRenderers.Droid
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            SetControlStyle();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetControlStyle();
        }

        void SetControlStyle()
        {
            if (Control != null)
            {
                Drawable imgDropDownArrow = Resources.GetDrawable(Resource.Drawable.ddarrow);
                imgDropDownArrow.SetBounds(5, 5, 5, 5);
                Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(null, null, imgDropDownArrow, null);
            }
        }
    }
}