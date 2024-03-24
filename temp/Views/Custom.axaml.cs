using System.Reactive;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using temp.ViewModels;

namespace temp.Views;

public partial class Custom : UserControl{
    public Custom(){
        InitializeComponent();
        CustomViewModel customViewModel = new CustomViewModel();
        ReactiveCommand<Unit, Unit> myCommand = ReactiveCommand.Create(customViewModel.thisWontWork);
        CustomButton.Command = myCommand;
    }

   
}