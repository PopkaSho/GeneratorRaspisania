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
            var maxYr = raspfiveclass.Select(i => i.LessonNumber).Max();
            List<RasspisainModel> raspis = new List<RasspisainModel>();
            for(int i=1; i<=maxYr ; i++) {
                var test = new RasspisainModel();
                for (int j = 1; j <= 11; j++ )
                {
                    if (j == 1)
                    {
                        test.OneClass = raspfiveclass.Where(k=> k.LessonNumber ==i&&k.Items.ClassID==j).FirstOrDefault();
                    }
                    if (j == 2)
                    {
                        test.TwoClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 3)
                    {
                        test.FreeClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 4)
                    {
                        test.FourClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 5)
                    {
                        test.FiveClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 6)
                    {
                        test.SixClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 7)
                    {
                        test.SevenClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 8)
                    {
                        test.EightClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 9)
                    {
                        test.OneClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 10)
                    {
                        test.NineClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                    if (j == 11)
                    {
                        test.TenClass = raspfiveclass.Where(k => k.LessonNumber == i && k.Items.ClassID == j).FirstOrDefault();
                    }
                   
                }
                raspis.Add(test);
            }
           
          
            GridRaspis.ItemsSource = raspis;
         
        }
    }
}
