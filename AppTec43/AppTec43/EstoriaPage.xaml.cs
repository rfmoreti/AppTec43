using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTec43
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstoriaPage : ContentPage
	{
		public EstoriaPage (string aluno)
		{
			InitializeComponent ();
            switch (aluno)
            {
                case "Aluno1":
                    vNome.Text = "Espiga";
                    vFoto.Source = "https://i.ibb.co/TtQRmWC/espiga.jpg";
                    vEstoria.Text = "Jaci";
                    break;
                case "Aluno2":
                    vNome.Text = "Lucas Hardware";
                    vFoto.Source = "https://i.ibb.co/RDjy8BZ/lucas.jpg";
                    vEstoria.Text = "Se eu fosse PM";
                    break;
                case "Aluno3":
                    vNome.Text = "Moreti";
                    vFoto.Source = "https://i.ibb.co/qgCjDqf/moreti.jpg";
                    vEstoria.Text = "Humor, piada, hahaha";
                    break;
                case "Aluno4":
                    vNome.Text = "Paulo Gibóia";
                    vFoto.Source = "https://i.ibb.co/PwccYxL/paulo.jpg";
                    vEstoria.Text = "Manja Rola";
                    break;
                case "Aluno5":
                    vNome.Text = "Pedro";
                    vFoto.Source = "https://i.ibb.co/xDzMfM9/pedro.jpg";
                    vEstoria.Text = "Esquerdo, mas não canhoto";
                    break;
                case "Aluno6":
                    vNome.Text = "Rafael Valério";
                    vFoto.Source = "https://i.ibb.co/1Tqzmjs/valerio.jpg";
                    vEstoria.Text = "Programador Real";
                    break;
                case "Aluno7":
                    vNome.Text = "Seninha";
                    vFoto.Source = "https://i.ibb.co/9GvWMsw/seninha.jpg";
                    vEstoria.Text = "Reencarnação do Ayrton";
                    break;
                case "Aluno8":
                    vNome.Text = "Uzias";
                    vFoto.Source = "https://i.ibb.co/340HJbw/uzias.jpg";
                    vEstoria.Text = "Morô, cara";
                    break;
                case "Aluno9":
                    vNome.Text = "Vitor";
                    vFoto.Source = "https://i.ibb.co/FB8fzz9/vitor.jpg";
                    vEstoria.Text = "Compra e amarra";
                    break;
                case "Aluno10":
                    vNome.Text = "Yan";
                    vFoto.Source = "https://i.ibb.co/YDPLNjk/yan.jpg";
                    vEstoria.Text = "Hacker real";
                    break;
                case "Aluno11":
                    vNome.Text = "Yuri";
                    vFoto.Source = "https://i.ibb.co/1sjJb71/yuri.jpg";
                    vEstoria.Text = "Otaku";
                    break;
                default:
                    break;
            }
        }

        private async void BtnNarrar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(vEstoria.Text);
        }
    }
}