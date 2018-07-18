using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IRepository<TEntity> where TEntity : AggregateRoot
    {
        #region 属性
        IQueryable<TEntity> Entities { get; }
        #endregion

        #region 公共方法
        int Insert(TEntity entity);

        int Insert(IEnumerable<TEntity> entities);

        int Delete(object id);

        int Delete(TEntity entity);

        int Delete(IEnumerable<TEntity> entities);

        int Update(TEntity entity);

        TEntity GetByKey(object key);
        #endregion
    }
}
