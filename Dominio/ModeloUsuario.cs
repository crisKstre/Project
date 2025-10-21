using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoData;

namespace Domain
{
    public class ModeloUsuario
    {
        UserDao userdao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userdao.Login(user, pass);
        }
    }





}
