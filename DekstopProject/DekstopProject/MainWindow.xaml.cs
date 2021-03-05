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
using System.Net;//!!!!!!!!!!!
using Newtonsoft.Json; //Качаем в NuGet

namespace DekstopProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Thing //класс - копия таблицы (не для entity)
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            var WebClient = new WebClient();
            WebClient.Encoding = Encoding.UTF8;
            string json = WebClient.DownloadString("https://localhost:44357/api/"); //меняем порт на свой
            List<Thing> things = JsonConvert.DeserializeObject<List<Thing>>(json);
            datagrid.ItemsSource = things;
        }
        private void btnGetWithId_Click(object sender, RoutedEventArgs e)
        {
            var WebClient = new WebClient();
            WebClient.Encoding = Encoding.UTF8;
            string json = WebClient.DownloadString("https://localhost:44357/api/"+txtGet.Text);//меняем порт на свой
            Thing thing = JsonConvert.DeserializeObject<Thing>(json);
            txtGet.Text = "name: " + thing.name;
        }

        private void btnPost_Click(object sender, RoutedEventArgs e) //метод в api должен принимать в теле экземпляр класса!
        {
            Thing table = new Thing();
            table.name = txtPost.Text;
            string json = JsonConvert.SerializeObject(table);

            var WebClient = new WebClient();
            WebClient.Encoding = Encoding.UTF8;
            WebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            WebClient.UploadString("https://localhost:44357/api/", json);//меняем порт на свой, загружаем объект класса
        }

        private void btnPut_Click(object sender, RoutedEventArgs e)//метод в api должен принимать интовый id и в теле экземпляр класса!
        {
            Thing table = new Thing();
            table.name = txtNamePut.Text;
            string json = JsonConvert.SerializeObject(table);

            var WebClient = new WebClient();
            WebClient.Encoding = Encoding.UTF8;
            WebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            string v = WebClient.UploadString("https://localhost:44357/api/"+txtIdPut.Text, "PUT", json);//меняем порт на свой, прибавляем к пути id обновляемого объекта, загружаем объект класса, указываем PUT
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var WebClient = new WebClient();
            WebClient.Encoding = Encoding.UTF8;
            WebClient.UploadString("https://localhost:44357/api/"+txtIdDelete.Text, "DELETE", "");//меняем порт на свой, прибавляем к пути id удаляемого объекта, указываем DELETE, пустые скобки - так надо
        }
    }
}
