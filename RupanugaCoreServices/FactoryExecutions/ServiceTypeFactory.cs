using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RupanugaCoreServices.FactoryExecutions
{
   public class ServiceTypeFactory : Factory<SharedModels.RupanugaOKCDBContext, ServiceType>, IServiceTypeFactory
    {
        public ServiceType GetSingleServiceType(int serviceTypeID) => GetAll().FirstOrDefault(svcType => svcType.ServiceTypeId == serviceTypeID);

        public List<ServiceType> GetAllServiceTypes() => GetAll().ToList();

    }
}
