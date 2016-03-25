using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYZJ.UserLimitMVC.IDAL;

namespace LYZJ.UserLimitMVC.DAL
{
    /// <summary>
    /// 此类不使用，只是为了说明简单工厂模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class RepositoryFactory<T> where T : class, new()
    {

        /// <summary>
        /// 简单工厂模式，最终会将其删除，，demo实例说明
        /// </summary>
        /// <param name="respository"></param>
        /// <returns></returns>
        public static IBaseRepository<T> CreateRepository(string respository)
        {
            IBaseRepository<T> baseRepository = null;
            switch (respository)
            {
                case "baseuser":
                    baseRepository = (IBaseRepository<T>) new BaseUserRepository();
                    break;
                case "baserole":
                    baseRepository = (IBaseRepository<T>) new BaseRoleRepository();
                    break;
            }
            return baseRepository;
        }


        public static IBaseUserRepository UserInfoRepository
        {
            get { return new BaseUserRepository(); }
        }

        public static IBaseRoleRepository RoleRepository
        {
            get { return new BaseRoleRepository(); }
        }
    }
}