namespace Infrastructura.ContextoDatos
{
    public class UsuariosTable
    {  /*ILectorDeCodigoSql<Usuario>

        public int FindUser(Usuario user)
        {

            SQLConfiguration instance = new SQLConfiguration();
            instance.OpenConnection();

            SqlCommand command = new SqlCommand("usp_ValidarUsuario", instance.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombreUsuario", SqlDbType.VarChar, 50).Value = user.NombreUsuario;
            command.Parameters.Add("@passWord", SqlDbType.VarChar, 50).Value = user.UserPasssword;
            SqlDataReader reader = command.ExecuteReader();

            int wasFound = 0;
            while (reader.Read())
            {
                wasFound = reader.GetInt32(0);
            }

            return wasFound;
        }
    }

    */
    }
}
