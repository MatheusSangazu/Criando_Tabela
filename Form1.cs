using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabela
{
    public partial class Form1 : Form
    {
        DataTable Tabela;

        public Form1()
        {
            InitializeComponent();
        }


        private DataTable CriaTabela()
        {

            Tabela = new DataTable();
            Tabela.Columns.Add("AlunoId",  typeof(int));
            Tabela.Columns.Add("Nome",     typeof(string));
            Tabela.Columns.Add("Idade",    typeof(int));
            Tabela.Columns.Add("Email",    typeof(string));
            Tabela.Columns.Add("Telefone", typeof(string));

            Tabela.Rows.Add(1, "Matheus Henrique da Silva Alves", 18, "barradeespacoe@gmail.com", "79981003085");
            Tabela.Rows.Add(2, "Lucas Felipe Mozart", 17, "LucasMozart@gmail.com", "79988003087");
            Tabela.Rows.Add(3, "Lara Moraes", 16, "LaraMacheroni@gmail.com", "79988103088");
            Tabela.Rows.Add(4, "Erick Jhonata Canuto Ferreira", 18, "ErickCanuto@gmail.com", "79981983777");
            Tabela.Rows.Add(5, "Leticia Santos ", 18, "LetiLeticia@gmail.com", "79981983085");

            return Tabela;
        }

        private void Btn_CriaTabela_Click(object sender, EventArgs e)
        {
            DataTable Tabela = CriaTabela();

            GridTable.DataSource = Tabela;

        }
    }
}
