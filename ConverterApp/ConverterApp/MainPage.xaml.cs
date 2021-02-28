using ConverterApp.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ConverterApp


{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contacts> myList;

        public ObservableCollection<Contacts> MyList
        {
            get { return myList; }
            set { myList = value; }
        }

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;

            MyList = new ObservableCollection<Contacts>();

            for (int i = 1; i < 10; i++)
            {
                MyList.Add(new Contacts() { Id = i, Name = "Student" + i.ToString(), Address = "Address" + i.ToString(), Image = "usa.png" });
            }

            ContactsList.ItemsSource = MyList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int tal1 = int.Parse(entryTal1.Text);
            int tal2 = int.Parse(entryTal2.Text);

            Regnemaskine plusRegnemaskine = new Regnemaskine();

            finalResult.Text = plusRegnemaskine.Plus(tal1, tal2);
        }

        //læg mærke til at kaldet til "minus"-metoden er lettere, fordi den er statisk. jeg skal ikke lave et "objekt" først, som jeg skal ovenover (med "new" keywordet).
        private void btnMinus_Clicked(object sender, EventArgs e)
        {
            int tal1 = int.Parse(entryTal1.Text);
            int tal2 = int.Parse(entryTal2.Text);

            finalResult.Text = Regnemaskine.Minus(tal1, tal2);
        }
    }
}