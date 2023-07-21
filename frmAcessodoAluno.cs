using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAcessodoAluno : Form
    {
        public frmAcessodoAluno()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inativarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criarMatriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairDoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarQRCode_Click(object sender, EventArgs e)
        {
            GerarQRCode();
        }

        private void GerarQRCode()
        {
            Url generator = new Url("https://app.cursosenap.com.br/Cursos/Index?IdTrilha=2016698#");

            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox1.Image = qrCode.GetGraphic(4);
        }

        private void gerarCódigoDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarQRCode();
        }

        private void inicarScanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Equipamento de Scanner não está ativado no seu Periferico de Entrada");
        }

        private void gerarScriptDeFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caro(a) aluno(a), Meu nome é Robson do Curso Senap / Seven Educação\r\n\r\nPercebemos que você faltou em nossa aula recente no dia 03, no horário de 12:00. Gostaríamos de lembrá-lo(a) da importância de comparecer às aulas para não perder nenhum conteúdo importante.\r\n\r\nCaso queira, estamos disponíveis para agendar uma reposição da aula. Por favor, nos informe qual seria a sua preferência de dia e horário para a reposição, e assim faremos o possível para atendê-lo(a).\r\n\r\nEstamos sempre à disposição para ajudá-lo(a) e garantir o seu sucesso acadêmico.\r\n\r\nAtenciosamente,\r\n[Curso Senap / Seven Educação]");
        }

        private void gerarScriptDeFaltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caro(a) aluno(a), Meu nome é Robson do Curso Senap / Seven Educação\r\n\r\nPercebemos que você faltou em nossa aula recente no dia 03, no horário de 12:00. Gostaríamos de lembrá-lo(a) da importância de comparecer às aulas para não perder nenhum conteúdo importante.\r\n\r\nCaso queira, estamos disponíveis para agendar uma reposição da aula. Por favor, nos informe qual seria a sua preferência de dia e horário para a reposição, e assim faremos o possível para atendê-lo(a).\r\n\r\nEstamos sempre à disposição para ajudá-lo(a) e garantir o seu sucesso acadêmico.\r\n\r\nAtenciosamente,\r\n[Curso Senap / Seven Educação]");
        }

        private void humbertoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gerarScriptDeFaltaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caro(a) aluno(a), Meu nome é Robson do Curso Senap / Seven Educação\r\n\r\nPercebemos que você faltou em nossa aula recente no dia 03, no horário de 12:00. Gostaríamos de lembrá-lo(a) da importância de comparecer às aulas para não perder nenhum conteúdo importante.\r\n\r\nCaso queira, estamos disponíveis para agendar uma reposição da aula. Por favor, nos informe qual seria a sua preferência de dia e horário para a reposição, e assim faremos o possível para atendê-lo(a).\r\n\r\nEstamos sempre à disposição para ajudá-lo(a) e garantir o seu sucesso acadêmico.\r\n\r\nAtenciosamente,\r\n[Curso Senap / Seven Educação]");
        }

        private void gerarJustificativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[Seu Nome]: Olá, Professor [Nome do Professor]. Desculpe por não ter comparecido à aula de [Disciplina] na última [Data]. Gostaria de me desculpar e justificar minha ausência.\r\n\r\n[Professor]: Tudo bem, [Nome do Aluno]. O que aconteceu?\r\n\r\n[Seu Nome]: Sofri uma indisposição repentina e não me senti bem o suficiente para comparecer à aula. Tentei tomar algumas medidas para melhorar, mas não obtive sucesso.\r\n\r\n[Professor]: Espero que esteja se sentindo melhor agora. Obrigado por me informar sobre a situação. Certifique-se de revisar o conteúdo que foi abordado na aula e, se tiver alguma dúvida, não hesite em me procurar.\r\n\r\n[Seu Nome]: Com certeza, professor. Agradeço pela compreensão e farei o possível para me atualizar sobre o conteúdo perdido. Novamente, peço desculpas pela falta e agradeço pela sua compreensão.\r\n\r\n[Professor]: Não se preocupe, [Nome do Aluno]. Entendo que imprevistos acontecem. Fique bem e nos vemos na próxima aula.\r\n\r\n[Seu Nome]: Obrigado, professor. Tenha um bom dia.");
        }

        private void gerarJustificativaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[Seu Nome]: Olá, Professor [Nome do Professor]. Desculpe por não ter comparecido à aula de [Disciplina] na última [Data]. Gostaria de me desculpar e justificar minha ausência.\r\n\r\n[Professor]: Tudo bem, [Nome do Aluno]. O que aconteceu?\r\n\r\n[Seu Nome]: Sofri uma indisposição repentina e não me senti bem o suficiente para comparecer à aula. Tentei tomar algumas medidas para melhorar, mas não obtive sucesso.\r\n\r\n[Professor]: Espero que esteja se sentindo melhor agora. Obrigado por me informar sobre a situação. Certifique-se de revisar o conteúdo que foi abordado na aula e, se tiver alguma dúvida, não hesite em me procurar.\r\n\r\n[Seu Nome]: Com certeza, professor. Agradeço pela compreensão e farei o possível para me atualizar sobre o conteúdo perdido. Novamente, peço desculpas pela falta e agradeço pela sua compreensão.\r\n\r\n[Professor]: Não se preocupe, [Nome do Aluno]. Entendo que imprevistos acontecem. Fique bem e nos vemos na próxima aula.\r\n\r\n[Seu Nome]: Obrigado, professor. Tenha um bom dia.");
        }

        private void gerarJustificativaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[Seu Nome]: Olá, Professor [Nome do Professor]. Desculpe por não ter comparecido à aula de [Disciplina] na última [Data]. Gostaria de me desculpar e justificar minha ausência.\r\n\r\n[Professor]: Tudo bem, [Nome do Aluno]. O que aconteceu?\r\n\r\n[Seu Nome]: Sofri uma indisposição repentina e não me senti bem o suficiente para comparecer à aula. Tentei tomar algumas medidas para melhorar, mas não obtive sucesso.\r\n\r\n[Professor]: Espero que esteja se sentindo melhor agora. Obrigado por me informar sobre a situação. Certifique-se de revisar o conteúdo que foi abordado na aula e, se tiver alguma dúvida, não hesite em me procurar.\r\n\r\n[Seu Nome]: Com certeza, professor. Agradeço pela compreensão e farei o possível para me atualizar sobre o conteúdo perdido. Novamente, peço desculpas pela falta e agradeço pela sua compreensão.\r\n\r\n[Professor]: Não se preocupe, [Nome do Aluno]. Entendo que imprevistos acontecem. Fique bem e nos vemos na próxima aula.\r\n\r\n[Seu Nome]: Obrigado, professor. Tenha um bom dia.");
        }

        private void fazerEstornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerando Estorno" , "GERANDO" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void dadosPessoaisToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            DadosdosAlunos DAdosDosAlunos = new DadosdosAlunos();
            DAdosDosAlunos.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAcessodoAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
