using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDAO
{
    internal interface IDAO<T>
    {

        int insert();
        int update();
        int delete();
        T findById();
        List<T> findAll();
        List<T> find();
    }
}
