using SaveToDataFolder.Interface;
using System;
using Xamarin.Forms;

namespace SaveToDataFolder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string message = TextMessage.Text;

            DependencyService.Get<IFileService>().CreateFile(message);
        }
    }
}
