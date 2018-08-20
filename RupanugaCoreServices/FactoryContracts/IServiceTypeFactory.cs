using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RupanugaCoreServices.FactoryContracts
{
   public interface IServiceTypeFactory : IFactory<ServiceType>
    {
        ServiceType GetSingleServiceType(int serviceTypeID);
        List<ServiceType> GetAllServiceTypes();

    }
}
