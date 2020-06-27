using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Entities;
using MySql.Data.MySqlClient;
namespace Services
{
    public class CommentService
    {
        public void InsertComment(Comments coment)
        {
            MySqlCommand sql;
            sql = new MySqlCommand(
                "INSERT INTO comments(idPlanet, comment)" +
                " VALUE (@idPlanet, @comment)");
            sql.Parameters.Add(new MySqlParameter("@idPlanet", coment.idPlanet));
            sql.Parameters.Add(new MySqlParameter("@comment", coment.comment));

            ConexaoBanco banco = new ConexaoBanco();
            banco.Connect();
            banco.Exec(sql);
            banco.Disconnect();
        }
    }
}
