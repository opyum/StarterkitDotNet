using Commun.Enums;
using DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoyanceApi.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Services.Tests;

namespace VoyanceApi.Services.Tests
{
    [TestClass()]
    public class ApplicationServiceTests : InitTest
    {
        [TestMethod()]
        public void GetAllApplicationsTest()
        {
            var test = applicationService.GetAll();
            Assert.IsTrue(test != null && test.Count > 0);
        }

        [TestMethod()]
        public void CreateNewApplicationTestOk()
        {
            ApplicationDTO dto = new ApplicationDTO()
            {
                CreatedBy = "UserTest",
                CreatedDateTime = DateTime.Now,
                Label = "AppliTest",
                ModifiedBy = "UserTest",
                ModifiedDateTime = DateTime.Now.AddDays(1),
            };
            var retour = applicationService.Create(dto);
            Assert.IsNotNull(retour);
            Assert.IsFalse(retour.HasError);

            applicationService.Delete(retour.Object.Id);
        }
        [TestMethod()]
        public void CreateNewApplicationTestFail()
        {
            ApplicationDTO dto = new ApplicationDTO()
            {
                Id=4,
                CreatedBy = "UserTest",
                CreatedDateTime = DateTime.Now,
                Label = "AppliTest",
                ModifiedBy = "UserTest",
                ModifiedDateTime = DateTime.Now.AddDays(1),
            };
            var retour = applicationService.Create(dto);
            Assert.IsNotNull(retour);
            Assert.IsTrue(retour.HasError);
        }

        [TestMethod()]
        public void DeleteApplicationTestFail()
        {
            var retour = applicationService.Delete(0);
            Assert.IsTrue(retour.Severity == SeverityEnum.ERROR);

        }
    }
}