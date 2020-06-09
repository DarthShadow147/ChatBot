using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.SQL;

namespace Domain
{
    public class SearchAnswerModel
    {
        private SearchAnswer Search = new SearchAnswer();

        public string SearchAnswer(string question)
        {
            string respuesta;
            respuesta = Search.Search(question);
            return respuesta;
        }
    }
}
