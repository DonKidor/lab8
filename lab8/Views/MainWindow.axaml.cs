using Avalonia.Controls;
using lab8.Models;

namespace lab8.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void AddClk(Note note)
        {
            var filter = new FileDialogFilter()
            {
                Name = "Images",
                Extensions = { "png", "bmp", "jpg" }
            };
            var dlg = new OpenFileDialog()
            {
                Title = "Open Image",
                Filters = { filter }
            }.ShowAsync(this.VisualRoot as MainWindow);
            var path = await dlg;
            if (path != null) note.setImage(path[0]);
        }
    }
}
