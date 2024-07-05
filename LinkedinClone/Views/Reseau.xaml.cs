using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class Reseau : ContentView
{
    public Reseau()
    {
        InitializeComponent();
        BindingContext = new ReseauViewModel();
    }
}