using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD_Example.Repositories.BaseRepositories
{
   public interface IBaseRepository<T>
    {
        void  GetActiveItems(DataGridView dataGridView);
        void Create(T item, DataGridView dataGridView);
        void Update(T item, DataGridView dataGridView);
        void Delete(T item, DataGridView dataGridView);
       
    }
}
