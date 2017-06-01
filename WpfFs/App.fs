open System
open FsXaml
open Gjallarhorn.Wpf
open WpfFs

type App = XAML<"App.xaml">
type MainWin = XAML<"MainWindow.xaml">

[<STAThread>]
[<EntryPoint>]
let main argv = 
    Framework.runApplication App MainWin Program.application