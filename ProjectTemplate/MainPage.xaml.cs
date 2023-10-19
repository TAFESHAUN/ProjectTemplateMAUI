using CsvHelper;
using ProjectTemplate.ViewModel;
using System.Collections.ObjectModel;
using System.Globalization;

namespace ProjectTemplate;

public partial class MainPage : ContentPage
{

    public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

        viewModel.ImportSomeRecords();
        
    }

    private void PersonDataGrid_ItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var selection = PersonDataGrid.SelectedItem as Person;

        DisplayAlert("Selected", $"FirstName {selection.firstName} lastname{selection.lastName} taxThreshold? {selection.taxthreshold}", "OK");
    }

    //BUTTON EVENT
    //var selection = PersonDataGrid.SelectedItem as Person;
    //PAYSLIP.id = PERSON.id DATA
}

