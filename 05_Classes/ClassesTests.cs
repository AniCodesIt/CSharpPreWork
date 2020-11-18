using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            cookie.GramsofFlour = 10;

            Cookie snickerdoodle = new Cookie("Snockerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }
        [TestMethod]
        public void VehicleTests()
        {
            vehicle car = new vehicle();
            car.TypeofVehicle = VehicleType.Skateboard;

            vehicle newCar = new vehicle
            {
                TypeofVehicle = VehicleType.Skateboard,
                Make = "Thrasher",
                Model = "Longboard"
            };
        }
        
    }
}
