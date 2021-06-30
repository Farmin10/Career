using AutoMapper;
using career.BLL.Abstract;
using career.DAL.DataAccess;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Concrete
{
    public class UserManager : IUserService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public UserManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(User user)
        {
            await _unitOfWork.UserDal.AddAsync(user);
        }

        public async Task<User> GetByUserName(string userName)
        {
            return await  _unitOfWork.UserDal.GetAsync(u => u.UserName == userName);
        }
    }
}
