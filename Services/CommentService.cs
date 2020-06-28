using System;
using System.Collections.Generic;
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
                "INSERT INTO comments(idPlanet, comment, name, date)" +
                " VALUE (@idPlanet, @comment, @name, @date)");
            sql.Parameters.Add(new MySqlParameter("@idPlanet", coment.idPlanet));
            sql.Parameters.Add(new MySqlParameter("@comment", coment.comment));
            sql.Parameters.Add(new MySqlParameter("@name", coment.name));
            sql.Parameters.Add(new MySqlParameter("@date", coment.date));

            ConexaoBanco banco = new ConexaoBanco();
            banco.Connect();
            banco.Exec(sql);
            banco.Disconnect();
        }

        public List<Comments> selectComments(string idPlanet)
        {
            MySqlCommand sql;
            sql = new MySqlCommand(
                "SELECT * FROM comments" +
                " WHERE idPlanet = @idPlanet");
            sql.Parameters.Add(new MySqlParameter("@idPlanet", idPlanet));

            ConexaoBanco banco = new ConexaoBanco();
            banco.Connect();
            MySqlDataReader reader = banco.Search(sql);
            List<Comments> com = new List<Comments>();
            while (reader.Read())
            {
                Comments comment = new Comments();
                comment.comment = reader.GetString("comment");
                comment.date = reader.GetString("date");
                comment.name = reader.GetString("name");
                comment.idPlanet = reader.GetString("idPlanet");
                com.Add(comment);
            }
            reader.Close();
            banco.Disconnect();
            return com;
        }
    }
}
