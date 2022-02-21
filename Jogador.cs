using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_PLayer
{
    class Jogador
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string email { get; set; }
        public string celular { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\CRUD_PLayer\\DbJogador.mdf;Integrated Security=True");

        public List<Jogador> listajogador()
        {
            List<Jogador> li = new List<Jogador>();
            string sql = "SELECT * FROM Jogador";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Jogador j = new Jogador();
                j.Id = (int)dr["Id"];
                j.nome = dr["nome"].ToString();
                j.cidade = dr["cidade"].ToString();
                j.email = dr["email"].ToString();
                j.celular = dr["celular"].ToString();
                li.Add(j);
            }
            return li;
        }
    }
}
