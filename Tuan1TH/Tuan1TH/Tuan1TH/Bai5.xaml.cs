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
    public partial class Bai5 : ContentPage
    {
        Label Txt = new Label();
        
        void render()
        {
            for (int i = 0; i < 6; i++)
            {
                screenca.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 4; i++)
            {
                screenca.ColumnDefinitions.Add(new ColumnDefinition());
            }


            screenca.Children.Add(Txt, 0, 0);
            Grid.SetColumnSpan(Txt, 4);
            string[] listtxtbtn = new string[] {"C","+/-","%","DIV","7","8","9","X","4","5","6","-",
            "1","2","3","+","0",".","="};
            for (int i = 0; i < listtxtbtn.Length; i++)
            {
                Button n = new Button { Text = listtxtbtn[i], HeightRequest = 100, Margin = 0 ,BorderWidth=0.1,BorderColor=Color.Black, CornerRadius=0};
                int d, c;
                c = i % 4;
                d = ((int)i / 4) + 1;
                
                
                if (i <= 2)
                    n.BackgroundColor = Color.Gray;
                else if (c == 3)
                    n.BackgroundColor = Color.Orange;
                else
                    n.BackgroundColor = Color.AntiqueWhite;
                n.Clicked += btn_Clicked;
                if (c == 0 && d == 5)
                {
                    Console.WriteLine(d.ToString() + "so " + n.Text.ToString() + " " + c.ToString());
                    Grid.SetColumnSpan(n, 2);
                    screenca.Children.Add(n,0, 5);

                }
                else if (c > 0 && d == 5)
                {
                    screenca.Children.Add(n, c+1, d);
                }
                else
                {
                    screenca.Children.Add(n, c, d);
                }
                
            }

        }
        string n1 = "", n2 = "";
        string toantu = "";
        double s1, s2;
        private void btn_Clicked(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            double n = 0;
            Console.WriteLine(btn.Text);
            double.TryParse(btn.Text, out n);
            if (n != 0)
            {
                if (toantu == "")
                {
                    n1=n1+btn.Text;
                    Txt.Text = n1;
                }
                else
                {
                    n2 = n2 + btn.Text;
                    Txt.Text=n1+" "+toantu+" " + n2;
                }
            }
            
            else
            {
                if (btn.Text == "C")
                {
                    Txt.Text = "";
                    n1 = "";
                    n2 = "";
                    toantu = "";
                }
                else if(btn.Text == "0")
                {
                    if (toantu == "")
                    {
                        n1 = n1 + btn.Text;
                        Txt.Text = n1;
                    }
                    else
                    {
                        n2 = n2 + btn.Text;
                        Txt.Text = n1 + " " + toantu + " " + n2;
                    }
                }
                else if (btn.Text == "=")
                {
                    double.TryParse(n1, out s1);
                    double.TryParse(n2, out s2);
                    if (toantu == "X")
                    {
                        Txt.Text = (s1 * s2).ToString();
                    }
                    else if (toantu == "-")
                    {
                        Txt.Text=(s1 - s2).ToString();
                    }
                    else if (toantu == "+")
                    {
                        Txt.Text =(s1 + s2).ToString();
                    }
                    else if(toantu == "%")
                    {
                        Txt.Text = (s1%s2).ToString();
                    }
                    else if (toantu == "DIV")
                    {
                        Txt.Text = (s1/s2).ToString();
                    }
                    n1 = "";
                    n2 = "";
                    toantu = "";
                }
                else
                {
                    toantu = btn.Text.ToString();
                }
                
                
            }
            
        }

        public Bai5()
        {
            InitializeComponent();
            render();
        }
    }
}