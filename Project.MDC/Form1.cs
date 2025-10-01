namespace Project.MDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBPERSONAGEM_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] nomePersonagens = Directory.GetFiles("C:\\Users\\undon\\OneDrive\\Imagens\\VS Project");

            foreach (string img in nomePersonagens)
            {
                string[] separador = img.Split('\\');
                string[] nomePersonagem = separador[6].Split('.');

                if (CBPERSONAGEM.Text == nomePersonagem[0])
                {
                    PBPERSONAGEM.ImageLocation = @"C:\\Users\\undon\\OneDrive\\Imagens\\VS Project\" + CBPERSONAGEM.Text + ".jpg";
                    PBPERSONAGEM.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (CBPERSONAGEM.Text == "BLADE")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Eric Brooks, conhecido como Blade, � um ca�ador de vampiros meio humano e meio vampiro. Al�m de ser imune aos poderes dos vampiros, Blade � um guerreiro implac�vel que luta para proteger a humanidade das amea�as sobrenaturais.";
                }
                if (CBPERSONAGEM.Text == "BLACK PANTHER")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "T'Challa, o Pantera Negra, � o rei de Wakanda, uma na��o africana tecnologicamente avan�ada. Ele possui habilidades sobre-humanas concedidas pela erva em forma de cora��o e � um mestre em combate corpo a corpo, al�m de ser um l�der s�bio e estrat�gico.";
                }
                if (CBPERSONAGEM.Text == "STAR LORD")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Peter Quill, tamb�m conhecido como Senhor das Estrelas, � um aventureiro espacial e l�der dos Guardi�es da Gal�xia. Ele � conhecido por seu carisma, habilidades de combate e seu amor pela m�sica dos anos 80, que o acompanha em suas aventuras pelo cosmos.";
                }
                if (CBPERSONAGEM.Text == "DAREDEVIL")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Matt Murdock, o Demolidor, � um advogado cego que combate o crime em Hell's Kitchen, Nova York. Apesar de sua cegueira, ele possui sentidos agu�ados e habilidades de combate excepcionais, tornando-se um vigilante implac�vel contra a injusti�a.";
                }
                if (CBPERSONAGEM.Text == "GHOST RIDER")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Johnny Blaze, o Motoqueiro Fantasma, � um motociclista que fez um pacto com o diabo para salvar a vida de seu pai. Como resultado, ele se transforma em um ser sobrenatural com uma caveira flamejante e poderes infernais, usando sua moto para combater o mal.";
                }
                if (CBPERSONAGEM.Text == "RED HOOD")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Jason Todd, o Capuz Vermelho, � um ex-Robin que se tornou um vigilante mais brutal. Ap�s ser ressuscitado, ele adota o manto do Capuz Vermelho e luta contra o crime com m�todos mais agressivos, muitas vezes entrando em conflito com Batman.";
                }
                if (CBPERSONAGEM.Text == "PEACEMAKER")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Christopher Smith, o Pacificador, � um diplomata que acredita na paz a qualquer custo, mesmo que isso signifique usar a viol�ncia. Ele � conhecido por sua habilidade em combate e seu lema controverso de que 'a paz � alcan�ada atrav�s da for�a'.";
                }
                if (CBPERSONAGEM.Text == "SPAWN")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Al Simmons, o Spawn, � um ex-soldado que faz um pacto com o diabo e retorna � Terra como um anti-her�i com poderes sobrenaturais. Ele luta contra for�as do mal enquanto busca reden��o por seus pecados passados.";
                }
                if (CBPERSONAGEM.Text == "BATMAN ABSOLUTE")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "O Batman do Universo Absoluto � um Bruce Wayne sem riqueza, que trabalha como engenheiro civil. Sem a fortuna e os recursos da Mans�o Wayne, este her�i � mais brutal e depende apenas do seu esfor�o e equipamentos auto-projetados para combater o crime em um universo sob a influ�ncia de Darkseid.";
                }
                if (CBPERSONAGEM.Text == "CONSTANTINE")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "John Constantine � um ocultista e exorcista brit�nico conhecido por sua ast�cia, cinismo e habilidades m�gicas. Ele frequentemente lida com dem�nios, fantasmas e outras entidades sobrenaturais, usando sua intelig�ncia e conhecimento do oculto para proteger o mundo das for�as das trevas.";
                }
            }
        }

        private void CBUNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBPERSONAGEM.Text = string.Empty;
            PBPERSONAGEM.ImageLocation = string.Empty;
            lblcharacter.Text = string.Empty;

            if (CBUNI.Text == "MARVEL")
            {
                CBPERSONAGEM.Items.Clear();
                CBPERSONAGEM.Items.Add("BLADE");
                CBPERSONAGEM.Items.Add("BLACK PANTHER");
                CBPERSONAGEM.Items.Add("STAR LORD");
                CBPERSONAGEM.Items.Add("DAREDEVIL");
                CBPERSONAGEM.Items.Add("GHOST RIDER");
            }
            else if (CBUNI.Text == "DC")
            {
                CBPERSONAGEM.Items.Clear();
                CBPERSONAGEM.Items.Add("RED HOOD");
                CBPERSONAGEM.Items.Add("PEACEMAKER");
                CBPERSONAGEM.Items.Add("SPAWN");
                CBPERSONAGEM.Items.Add("BATMAN ABSOLUTE");
                CBPERSONAGEM.Items.Add("CONSTANTINE");
            }
        }

        private void PBPERSONAGEM_Click(object sender, EventArgs e)
        {

        }

        private void lblcharacter_Click(object sender, EventArgs e)
        {
           

        }
    }
}
