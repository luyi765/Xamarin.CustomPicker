using System.ComponentModel;
using Telirium.XFRenderers;
using Telirium.XFRenderers.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]

namespace Telirium.XFRenderers.iOS
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
                var imgDropDownArrow = UIImage.FromFile("ddarrow.png");
                Control.RightViewMode = UITextFieldViewMode.Always;
                Control.RightView = new UIImageView(imgDropDownArrow);
            }
        }


    }
}