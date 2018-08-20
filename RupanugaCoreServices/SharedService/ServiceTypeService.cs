using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RupanugaCoreServices.SharedService
{
   public class ServiceTypeService : BaseService, IServiceTypeService
    {
        IServiceTypeFactory serviceTypeFactory;
        public ServiceTypeService(IServiceTypeFactory _serviceTypeFactory)
        {
            serviceTypeFactory = _serviceTypeFactory;
        }
        public ServiceType GetServiceTypeByID(int serviceTypeID) => serviceTypeFactory.GetSingleServiceType(serviceTypeID);

        public List<ServiceType> GetAllServiceTypes() => serviceTypeFactory.GetAllServiceTypes();
    
    }
}
