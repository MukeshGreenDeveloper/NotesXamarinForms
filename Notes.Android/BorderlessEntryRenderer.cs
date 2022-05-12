using Android.App;
using Android.Content;
using Notes;
using Notes.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(NoLineEntry), typeof(BorderlessEntryRenderer))]
namespace Notes.Droid
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public BorderlessEntryRenderer(Context context) : base(context) {
           
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.Background = null;
            Control?.SetPadding(20, 20, 20, 20);
        }
    }
}