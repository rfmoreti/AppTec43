using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTec43
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TurmaPage : ContentPage
	{
        string aluno;
		public TurmaPage ()
		{
			InitializeComponent ();
           
		}       

        private void BtnAluno11_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno11";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno10_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno10";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno9_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno9";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno8_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno8";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno7_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno7";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno6_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno6";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno5_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno5";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno4_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno4";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno3_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno3";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }

        private void BtnAluno2_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno2";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }
        private void BtnAluno1_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno1";
            Navigation.PushAsync(new EstoriaPage(aluno));
        }
    }
}