using career.DTO.DepartmantDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{
    public interface IDepartmantService
    {
        List<GetDepartmantDto> GetAll();
    }
}
