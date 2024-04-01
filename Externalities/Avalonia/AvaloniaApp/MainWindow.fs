namespace AvaloniaApp

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml

type MainWindow () as this = 
    inherit Window ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
#if DEBUG
        this.AttachDevTools()
#endif
        this.Title <- "AvaloniaApp"
        this.Width <- 800.0
        this.Height <- 450.0
        this.Content <- "Hello World!"
