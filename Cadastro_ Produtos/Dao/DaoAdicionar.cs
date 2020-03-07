using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro__Produtos.Dao
{
    class DaoAdicionar
    {

        private Conexao Conexão = new Conexao();


        public void Adicionar( Add)
        {
            string InsertAbastecimento = "INSERT INTO ABASTECIMENTO(KM_NO_ABASTECIMENTO, LITROS, VALOR, ID_POSTO, DATA) VALUES (@KM_NO_ABASTECIMENTO, @LITROS, @VALOR, @ID_POSTO, @DATA);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertAbastecimento);
            command.Parameters.Add("@KM_NO_ABASTECIMENTO", MySqlDbType.Float).Value = Add.Km_No_Abastecimento;
            command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Add.Litros;
            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Add.Valor;
            command.Parameters.Add("@ID_POSTO", MySqlDbType.Int32).Value = Add.ID_Posto;
            command.Parameters.Add("@DATA", MySqlDbType.Date).Value = Add.Data;
            Conexão.Desconectar();
        }
    }
}