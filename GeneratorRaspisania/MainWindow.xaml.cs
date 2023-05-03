using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneratorRaspisania
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /////             <DataGrid.Columns>
    //            <DataGridTextColumn Header = "5 Класс" Binding="{Binding Items.Name}" Width="*"></DataGridTextColumn>
    //            <DataGridTextColumn x:Name="SemClass" Header="6 Класс" Width="*"></DataGridTextColumn>
    //            <DataGridTextColumn Header = "7 Класс" Width="*"></DataGridTextColumn>
    //            <DataGridTextColumn Header = "8 Класс" Width="*"></DataGridTextColumn>
    //            <DataGridTextColumn Header = "9 Класс" Width="*"></DataGridTextColumn>
    //            <DataGridTextColumn Header = "10 Класс" Width="*"></DataGridTextColumn>
    //            <DataGridTextColumn Header = "11 Класс" Width="*"></DataGridTextColumn>

    //        </DataGrid.Columns>
    public partial class MainWindow : Window
    {


        Entities entities = new Entities();
        public MainWindow()
        {
            InitializeComponent();
            var raspfiveclass = entities.RaspisanieYrokov.ToList();
            raspfiveclass = raspfiveclass.Where(p => p.Items.Classes.Id == 5).ToList();
            GridRaspis.ItemsSource = entities.RaspisanieYrokov.ToList();
        }
    }
}
