using Android.App;
using Android.Content;
using Notes;
using Notes.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(NoLineEditor), typeof(BorderlessEditorRenderer))]
namespace Notes.Droid
{
    public class BorderlessEditorRenderer : EditorRenderer 
    {
        public BorderlessEditorRenderer(Context context) : base(context) {
           
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            this.Control.Background = null;
            Control?.SetPadding(20, 20, 20, 20);
        }
    }
}