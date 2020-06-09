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
    public class LearnModel
    {
        private LearnDao Learn = new LearnDao();

        public void InsertQuestion(string question, string answer)
        {
            Learn.InsertQuestion(question,answer);
        }
    }
}
