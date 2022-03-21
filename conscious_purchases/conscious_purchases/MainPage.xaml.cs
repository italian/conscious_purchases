using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace conscious_purchases
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_yes_1_Clicked(object sender, EventArgs e)
        {
            button_yes_1.IsEnabled = false;
            button_no_1.IsEnabled = false;

            label_really.IsVisible = true;
            grid_really.IsVisible = true;
        }

        private async void Button_no_1_Clicked(object sender, EventArgs e)
        {
            button_yes_1.IsEnabled = false;
            button_no_1.IsEnabled = false;

            await DisplayAlert("Не покупайте", "Это вам не нужно", "OK");

            Start();
        }

        private void Button_yes_really_Clicked(object sender, EventArgs e)
        {
            button_yes_really.IsEnabled = false;
            button_no_really.IsEnabled = false;

            label_yesterday.IsVisible = true;
            grid_yesterday.IsVisible = true;
        }

        private async void Button_no_really_Clicked(object sender, EventArgs e)
        {
            button_yes_really.IsEnabled = false;
            button_no_really.IsEnabled = false;

            await DisplayAlert("Не покупайте", "Серьезно, вам это не нужно", "OK");

            Start();
        }

        private void button_yes_yesterday_Clicked(object sender, EventArgs e)
        {
            button_yes_yesterday.IsEnabled = false;
            button_no_yesterday.IsEnabled = false;

            label_rent.IsVisible = true;
            grid_rent.IsVisible = true;
        }

        private async void button_no_yesterday_Clicked(object sender, EventArgs e)
        {
            button_yes_yesterday.IsEnabled = false;
            button_no_yesterday.IsEnabled = false;

            await DisplayAlert("Не покупайте", "Подождите 30 дней (или пока оно вам не понадобится)", "OK");

            Start();
        }

        private async void button_yes_rent_Clicked(object sender, EventArgs e)
        {
            button_yes_rent.IsEnabled = false;
            button_no_rent.IsEnabled = false;

            await DisplayAlert("Так и сделайте!", "Одолжите или арендуйте это", "OK");

            Start();
        }

        private void button_no_rent_Clicked(object sender, EventArgs e)
        {
            button_yes_rent.IsEnabled = false;
            button_no_rent.IsEnabled = false;

            label_keep.IsVisible = true;
            grid_keep.IsVisible = true;
        }

        private async void button_yes_keep_Clicked(object sender, EventArgs e)
        {
            button_yes_keep.IsEnabled = false;
            button_no_keep.IsEnabled = false;

            await DisplayAlert("Покупайте", "Ищите качественное", "OK");

            Start();
        }

        private async void button_no_keep_Clicked(object sender, EventArgs e)
        {
            button_yes_keep.IsEnabled = false;
            button_no_keep.IsEnabled = false;

            await DisplayAlert("Не покупайте", "Вам это не нужно", "OK");

            Start();
        }

        private void Start()
        {
            button_yes_1.IsEnabled = true;
            button_no_1.IsEnabled = true;
            button_yes_really.IsEnabled = true;
            button_no_really.IsEnabled = true;
            button_yes_yesterday.IsEnabled = true;
            button_no_yesterday.IsEnabled = true;
            button_yes_rent.IsEnabled = true;
            button_no_rent.IsEnabled = true;
            button_yes_keep.IsEnabled = true;
            button_no_keep.IsEnabled = true;

            label_really.IsVisible = false;
            grid_really.IsVisible = false;
            label_yesterday.IsVisible = false;
            grid_yesterday.IsVisible = false;
            label_rent.IsVisible = false;
            grid_rent.IsVisible = false;
            label_keep.IsVisible = false;
            grid_keep.IsVisible = false;
        }
    }
}
