using AutoMapper;
using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;
using DTOs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ServiceTest;
using StarterKitAPI.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
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

        [TestMethod()]
        public void CreatePersonneGenericTest()
        {
            // Get a Type object.
            Assembly assembly = Assembly.Load("StarterKitAPI");
            Type myType = assembly.GetType("StarterKitAPI.Services.PersonneService");
            var assemblyName = myType.Assembly.FullName.ToString();
            //// Instantiate an Assembly class to the assembly housing the Integer type.
            //Assembly assem = Assembly.GetAssembly(t);
            // Get a Type object.
            //Type t = Type.GetType("StarterKitAPI.Services.PersonneService");
            // Instantiate an Assembly class to the assembly housing the Integer type.
            MethodInfo method = myType.GetMethod("GetAll");
            
            object obj = ActivatorUtilities.CreateInstance<PersonneService>(provider);

            var retour = method.Invoke(obj, null);

            Assert.IsNotNull(retour);

            //personneService.CreatePersonne(new PersonneDTO());
            //Assert.Fail();
        }
    }
}