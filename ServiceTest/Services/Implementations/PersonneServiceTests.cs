using AutoMapper;
using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;
using DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ServiceTest;
using StarterKitAPI.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKitAPI.Services.Tests
{
    [TestClass()]
    public class PersonneServiceTests : InitTest
    {

        [TestMethod()]
        public void CreatePersonneTest()
        {
            personneService.CreatePersonne(new PersonneDTO());
            Assert.Fail();
        }
    }
}