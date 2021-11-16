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
using LearningMaterials.Model;

namespace LearningMaterials.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewingDate.xaml
    /// </summary>
    public partial class ViewingDate : Page
    {
        public ViewingDate()
        {
            InitializeComponent();

            var allType = LearnEntities.Context.SourceLore.ToList();
            allType.Insert(0, new SourceLore
            {
                Name = "Все источники"
            });
            SourceBox.ItemsSource = allType;
            SourceBox.SelectedIndex = 0;

            LViewDate.ItemsSource = LearnEntities.Context.Learn.ToList();
        }
    }
}
