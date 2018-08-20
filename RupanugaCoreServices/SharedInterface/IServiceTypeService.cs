using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RupanugaCoreServices.SharedInterface
{
   public interface IServiceTypeService:IBaseService
    {
        ServiceType GetServiceTypeByID(int serviceTypeID);
        List<ServiceType> GetAllServiceTypes();
    }
}
