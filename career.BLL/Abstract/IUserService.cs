using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{

    public interface IUserService
    {
        Task Add(User user);
        Task<User> GetByUserName(string userName);
    }
}
