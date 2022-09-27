using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan1TH
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai2 : ContentPage
    {
        void render()
        {
            for (int i = 0; i < 4; i++)
            {
                Net.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for(int i = 0; i < 4; i++)
            {
                Net.RowDefinitions.Add(new RowDefinition());    
            }
            for(var i = 0; i < 4; i++)
            {
                BoxView n1=new BoxView();
                BoxView n2 = new BoxView();
                BoxView n3 = new BoxView();
                BoxView n4 = new BoxView();
                
                n2.Color = Color.BlueViolet;
                n4.Color = Color.BlueViolet;
                n1.Color = Color.Khaki;
                n3.Color = Color.Khaki;
                if (i %2==0)
                {
                    n1.Color = Color.BlueViolet;
                    n3.Color = Color.BlueViolet;
                    n2.Color = Color.Khaki;
                    n4.Color = Color.Khaki;

                }
                
               

                Net.Children.Add(n1, i, 0);
                Net.Children.Add(n2, i, 1);
                Net.Children.Add(n3, i, 2);
                Net.Children.Add(n4, i, 3);
            }
        }
        public Bai2()
        {
            InitializeComponent();
            render();
        }
    }
}