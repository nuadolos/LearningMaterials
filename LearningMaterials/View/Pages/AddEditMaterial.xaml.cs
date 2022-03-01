using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LearningMaterials.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditMaterial.xaml
    /// </summary>
    public partial class AddEditMaterial : Page
    {
        #region Свойства и поля

        private Learn currentLearn = new Learn();

        #endregion

        #region Конструктор страницы AddEditMaterial

        public AddEditMaterial(Learn selectedLearn)
        {
            InitializeComponent();

            if (selectedLearn != null)
                currentLearn = selectedLearn;

            SourceCBox.ItemsSource = Transition.Context.SourceLore.ToList();
            if (currentLearn.IsStudying)
                StudyingCBox.SelectedIndex = 1;
            else
                StudyingCBox.SelectedIndex = 0;

            DataContext = currentLearn;
        }

        #endregion

        #region Сохранение новых данных или изменений после редактирования

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentLearn.Name))
                error.AppendLine("Укажите название;");
            if (string.IsNullOrWhiteSpace(currentLearn.Link))
                error.AppendLine("Укажите ссылку;");
            if (string.IsNullOrWhiteSpace(currentLearn.SourceLoreId.ToString()))
                error.AppendLine("Выберите ресурс;");
            if (string.IsNullOrWhiteSpace(currentLearn.CreateDate.ToString()))
                error.AppendLine("Укажите дату создания");
            if (string.IsNullOrWhiteSpace(currentLearn.IsStudying.ToString()))
                error.AppendLine("Выберите статус изучения");

            if (error.Length > 0)
            {
                MessageBox.Show($"При сохранении возникли следующие ошибки:\n{error}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            switch (StudyingCBox.SelectedIndex)
            {
                case 0:
                    currentLearn.IsStudying = false;
                    break;
                case 1:
                    currentLearn.IsStudying = true;
                    break;
            }

            if (currentLearn.Id == 0)
                Transition.Context.Learn.Add(currentLearn);

            try
            {
                Transition.Context.SaveChanges();
                MessageBox.Show($"Данные сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                Transition.MainFrame.GoBack();
            }
            catch (Exception er)
            {
                MessageBox.Show($"При сохранении возникла ошибка: {er.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        #endregion

        #region Обновление фото после ввода ссылки в ImagePath

        private void ImagePath_TextChanged(object sender, TextChangedEventArgs e)
        {
            BitmapImage bitImage = new BitmapImage();

            if (ImagePath.Text.Contains("https://i.ibb.co/"))
            {
                bitImage.BeginInit();
                bitImage.UriSource = new Uri(ImagePath.Text);
                bitImage.EndInit();
            }

            DownImage.Source = bitImage;
        }

        #endregion

        #region Открытие браузера для загрузки пользовательских картинок

        //В дальнейшем этот блок необходимо довести до автоматизации 
        //Пользователей выбирает фотографию или перекидывает ее в определенное поле
        //После чего программа автоматически заливает фото в облако
        //И добавляет в поле ссылку на фото

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://imgbb.com/upload");
            e.Handled = true;
        }

        #endregion
    }
}
