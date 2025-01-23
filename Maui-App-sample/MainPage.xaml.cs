#if ANDROID
using Android_Bindings;
using Com.Example.Androidlibrary;
#endif
namespace Maui_App_sample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
#if ANDROID
            label.Text = $"Adding 8 +9 from Android Bindings: {new MathOperations().Add(8,9)}";
#endif
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
