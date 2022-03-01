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
using LearningMaterials.Utils;
using LearningMaterials.View.Pages;

namespace LearningMaterials.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewingDate.xaml
    /// </summary>
    public partial class ViewingDate : Page
    {
        #region Закрытые свойства и поля

        private List<Learn> LearnList { get { return Transition.Context.Learn.ToList(); } }
        private NavigateList navigate;

        #endregion

        #region Коструктор страницы ViewingDate

        public ViewingDate()
        {
            InitializeComponent();

            navigate = new NavigateList();

            var allType = Transition.Context.SourceLore.ToList();
            allType.Insert(0, new SourceLore
            {
                Name = "Все источники"
            });
            SourceBox.ItemsSource = allType;
            SourceBox.SelectedIndex = 0;
            TypeSort.SelectedIndex = 0;

            ViewMaterials.ItemsSource = LearnList;
        }

        #endregion

        #region Сортировка и фильтрация ViewMaterials

        private void SortingFilteringData()
        {
            var tempLearn = LearnList;

            if (SearchBox.Text != "Введите для поиска")
                tempLearn = tempLearn.Where(p => p.Name.ToLower().Contains(SearchBox.Text.ToLower())
                || p.Link.ToLower().Contains(SearchBox.Text.ToLower())
                || p.CreateDate.ToString().Contains(SearchBox.Text.ToLower())).ToList();

            if (SourceBox.SelectedIndex > 0)
                tempLearn = tempLearn.Where(p => p.SourceLore.Name == (SourceBox.SelectedItem as SourceLore).Name.ToString()).ToList();

            switch (TypeSort.SelectedIndex)
            {
                case 1:
                    {
                        if (!(bool)OrderCheck.IsChecked)
                            tempLearn = tempLearn.OrderBy(p => p.Name).ToList();
                        else
                            tempLearn = tempLearn.OrderByDescending(p => p.Name).ToList();
                        break;
                    }
                case 2:
                    {
                        if (!(bool)OrderCheck.IsChecked)
                            tempLearn = tempLearn.OrderBy(p => p.CreateDate).ToList();
                        else
                            tempLearn = tempLearn.OrderByDescending(p => p.CreateDate).ToList();
                        break;
                    }
            }

            navigate.EndIndex = tempLearn.Count;

            if (navigate.UsedBySearch)
                BtnNextPage.Visibility = Visibility.Hidden;
            else
                BtnNextPage.Visibility = Visibility.Visible;

            if (tempLearn.Count == 0)
                ViewMaterials.Visibility = Visibility.Hidden;
            else
                ViewMaterials.Visibility = Visibility.Visible;

            for (int i = navigate.CountOut; i > 0; i--)
            {
                try
                {
                    ViewMaterials.ItemsSource = tempLearn.GetRange(navigate.StartIndex, i);
                    break;
                }
                catch (Exception)
                {

                }
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text != "Введите для поиска")
            {
                navigate.NumberPage = 1;
                ControlOutList();
            }
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text == "")
                SearchBox.Text = "Введите для поиска";
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = null;
        }

        private void TypeSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigate.NumberPage = 1;
            ControlOutList();
        }

        private void SourceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigate.NumberPage = 1;
            ControlOutList();
        }

        private void OrderCheck_Checked(object sender, RoutedEventArgs e)
        {
            navigate.NumberPage = 1;
            ControlOutList();
        }

        private void OrderCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            navigate.NumberPage = 1;
            ControlOutList();
        }

        #endregion

        #region Навигация по ViewMaterials

        private void BtnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            navigate.NumberPage -= 1;
            ControlOutList();
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {
            navigate.NumberPage += 1;
            navigate.GetIndex();

            SortingFilteringData();

            if (navigate.HasPreviousPage)
                BtnPreviousPage.Visibility = Visibility.Visible;
            if (navigate.NumberPage == navigate.TotalPage)
                BtnNextPage.Visibility = Visibility.Hidden;
        }

        private void ControlOutList()
        {
            navigate.GetIndex();

            if (!navigate.HasPreviousPage)
                BtnPreviousPage.Visibility = Visibility.Hidden;
            if (navigate.HasNextPage)
                BtnNextPage.Visibility = Visibility.Visible;

            SortingFilteringData();
        }

        #endregion

        #region Переход на страницу добавления и редактирования данных

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Transition.MainFrame.Navigate(new AddEditMaterial(null));
        }

        private void ViewMaterials_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var tempData = ViewMaterials.SelectedItem as Learn;

            if (tempData != null)
                Transition.MainFrame.Navigate(new AddEditMaterial(ViewMaterials?.SelectedItem as Learn));
        }

        #endregion

        #region Обновление ViewMaterials после добавления или редактирования

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Transition.Context.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                SortingFilteringData();
            }
        }

        #endregion
    }
}
