
export class GuestInfo {
    guestInfoId: number;
    phone: number;
    userName: string;
    firstName: string;
    lastName: string;
    emailAddress: string;
    addressId: number;
    dob: Date;
    age: number;
    active: boolean;
}

export class GuestInfoServiceType {
    GuestInfoServiceTypeId: number;
    GuestInfo: GuestInfo;
    ServiceType: ServiceType;
}

export class ServiceType
{
    ServiceTypeId: number;
    ServiceTypeName: string;
    ServiceDescription: string;
    IsActive: boolean;
}

export class Volunteer {
    Name: string;
    phone: number;
    emailAddress: string;
    services: number[];
}

