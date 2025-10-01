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
                    lblcharacter.Text = "Eric Brooks, conhecido como Blade, é um caçador de vampiros meio humano e meio vampiro. Além de ser imune aos poderes dos vampiros, Blade é um guerreiro implacável que luta para proteger a humanidade das ameaças sobrenaturais.";
                }
                if (CBPERSONAGEM.Text == "BLACK PANTHER")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "T'Challa, o Pantera Negra, é o rei de Wakanda, uma nação africana tecnologicamente avançada. Ele possui habilidades sobre-humanas concedidas pela erva em forma de coração e é um mestre em combate corpo a corpo, além de ser um líder sábio e estratégico.";
                }
                if (CBPERSONAGEM.Text == "STAR LORD")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Peter Quill, também conhecido como Senhor das Estrelas, é um aventureiro espacial e líder dos Guardiões da Galáxia. Ele é conhecido por seu carisma, habilidades de combate e seu amor pela música dos anos 80, que o acompanha em suas aventuras pelo cosmos.";
                }
                if (CBPERSONAGEM.Text == "DAREDEVIL")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Matt Murdock, o Demolidor, é um advogado cego que combate o crime em Hell's Kitchen, Nova York. Apesar de sua cegueira, ele possui sentidos aguçados e habilidades de combate excepcionais, tornando-se um vigilante implacável contra a injustiça.";
                }
                if (CBPERSONAGEM.Text == "GHOST RIDER")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Johnny Blaze, o Motoqueiro Fantasma, é um motociclista que fez um pacto com o diabo para salvar a vida de seu pai. Como resultado, ele se transforma em um ser sobrenatural com uma caveira flamejante e poderes infernais, usando sua moto para combater o mal.";
                }
                if (CBPERSONAGEM.Text == "RED HOOD")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Jason Todd, o Capuz Vermelho, é um ex-Robin que se tornou um vigilante mais brutal. Após ser ressuscitado, ele adota o manto do Capuz Vermelho e luta contra o crime com métodos mais agressivos, muitas vezes entrando em conflito com Batman.";
                }
                if (CBPERSONAGEM.Text == "PEACEMAKER")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Christopher Smith, o Pacificador, é um diplomata que acredita na paz a qualquer custo, mesmo que isso signifique usar a violência. Ele é conhecido por sua habilidade em combate e seu lema controverso de que 'a paz é alcançada através da força'.";
                }
                if (CBPERSONAGEM.Text == "SPAWN")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "Al Simmons, o Spawn, é um ex-soldado que faz um pacto com o diabo e retorna à Terra como um anti-herói com poderes sobrenaturais. Ele luta contra forças do mal enquanto busca redenção por seus pecados passados.";
                }
                if (CBPERSONAGEM.Text == "BATMAN ABSOLUTE")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "O Batman do Universo Absoluto é um Bruce Wayne sem riqueza, que trabalha como engenheiro civil. Sem a fortuna e os recursos da Mansão Wayne, este herói é mais brutal e depende apenas do seu esforço e equipamentos auto-projetados para combater o crime em um universo sob a influência de Darkseid.";
                }
                if (CBPERSONAGEM.Text == "CONSTANTINE")
                {
                    lblcharacter.Visible = true;
                    lblcharacter.Text = "John Constantine é um ocultista e exorcista britânico conhecido por sua astúcia, cinismo e habilidades mágicas. Ele frequentemente lida com demônios, fantasmas e outras entidades sobrenaturais, usando sua inteligência e conhecimento do oculto para proteger o mundo das forças das trevas.";
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
