using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public enum RestrictionZone
    {
        EU,
        USAStates,
        Canada,
        Oceania,
        WarZone,       
    }

    public enum Country
    {
        //list all countries with value for continent
        California,
        Australia,
        NewZealand,
        England,
        Scotland, 
        Wales,
        Poland,
        France,
        Germany,
        Italy,
        Spain,
        Norway
        

    }

    public enum Continent
    {
        NorthAmerica,
        SouthAmerica,
        Oceania,
        Europe,
        Asia,
        Africa
    }

    public enum Stand
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    public enum PaymentOption
    {
        Card,
        Cash
    }

    public enum Rank
    {
        Junior,
        TeamMember,
        TeamLead,
        Manager,
        Director,
        CEO        
    }

    public enum Department
    {
        Shopping,
        FlightOperator,
        CustomerService,
        Development,
        Marketing,
        Administration,
        Security
    }

    public enum JobStatus
    {
        Contract, // (includes intern = rank is junior)
        Probation,
        Permament,
        Left
    }

    public enum EquipmentType
    {
        Technology,
        Transportation,
        Furniture
    }

    public enum TransportationEquipment
    {
        airplaneStairs,
        bus,
        car,
    }

    public enum TechnologyEquipment
    {
        Computer,
        Laptop,
        Mobile,
        Phone,        
    }

    public enum Furniture
    {

    }

    public enum PlaneType
    {
        bigPlane,
        mediumPlane,
        G47,       
        AK9
    }

    public enum PlaneManufacturer
    {
        Porsche,
        VW
    }

}
