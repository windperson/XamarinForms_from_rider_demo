using System;
using Xamarin.Forms;

namespace XamarinFormApp
{
    public partial class XamarinFormAppPage : ContentPage
    {
        public XamarinFormAppPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button clicked!");
        }
    }
}