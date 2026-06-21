using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad4dasya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            ValueSlider.ValueChanged += OnSliderValueChanged;
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueLabel.Text = $"Текущее значение: {Math.Round(e.NewValue, 0)}";
        }

        private void OnStaticClicked(object sender, EventArgs e)
        {
            double maxValue = ValueSlider.Maximum;
            string selectedItem = SelectPicker.SelectedItem?.ToString() ?? "не выбрано";

            ResultLabel.Text = $"Выбранный элемент: {selectedItem}\n" +
                               $"Максимальное значение слайдера: {maxValue}";

            ResultFrame.IsVisible = true;
        }
    }
}
