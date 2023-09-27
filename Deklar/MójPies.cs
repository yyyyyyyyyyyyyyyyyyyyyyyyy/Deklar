

using Popup;
using System;

using System.ComponentModel;

using System.Windows;



namespace Deklar

{

    public partial class MainWindow : Window

    {

        public MainWindow()

        {

            InitializeComponent();

            DataContext = new MyDog();

        }



        private void BtnWyslij_Click(object sender, RoutedEventArgs e)

        {

            MyDog dog = DataContext as MyDog;

            MójPies pies = new MójPies();

            string dane = pies.ZbierzDane(txtImieWlasciciela.Text, txtNazwiskoWlasciciela.Text, txtNazwaPsa.Text, dog.DtB);

            pies.ZapiszDane(dane);

            MessageBox.Show("Dane zapisane!");

        }

    }



  internal class MyDog:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void checkPropertyChangeEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private DateTime dtB;
            public DateTime DtB
        {
            get { return dtB; }
            set { dtB = value;
                checkPropertyChangeEvent("DtB");
            }
        }
    }

}