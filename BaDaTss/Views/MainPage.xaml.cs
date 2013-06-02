using System;

using StyleMVVM.View;

using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using LayoutAwarePage = BaDaTss.Common.LayoutAwarePage;

namespace BaDaTss
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    [StartPage]
    public sealed partial class MainPage : LayoutAwarePage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var snd = new MediaElement();
            StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync("Sounds");
            StorageFile file = await folder.GetFileAsync("sound.mp3");
            var stream = await file.OpenAsync(FileAccessMode.Read);
            snd.SetSource(stream, file.ContentType);
            snd.Play();
        }
    }
}
