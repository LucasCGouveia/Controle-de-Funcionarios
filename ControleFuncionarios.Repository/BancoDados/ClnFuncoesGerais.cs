﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;//Importar ADO
using System.Data.SqlClient; //Importar SQL
//using System.Threading.Tasks;

namespace ControleFuncionarios.Repository.BancoDados
{
    public class ClnFuncoesGerais
    {
        public enum Operacao
        {
            Inclusao, Alteracao, TabelaCep
        }
    }
}
