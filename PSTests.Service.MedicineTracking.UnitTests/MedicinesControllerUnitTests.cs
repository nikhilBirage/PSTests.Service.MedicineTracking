using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PSTests.Service.MedicineTracking.Controllers;
using PSTests.Service.MedicineTracking.Repository;
using PSTests.Service.MedicineTracking.Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PSTests.Service.MedicineTracking.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class MedicinesControllerUnitTests
    {
        private MedicinesController _controller;
        private Mock<IMedicineRepository> mockRepository;
        private List<Medicine> mockData = new List<Medicine>()
        {
            new Medicine()
            {
                Id = 1,
                Name = "M1",
               Brand = "ABC",
               Notes = "",
               Price = 10,
               Quantity = 10,
               ExpiryDate = DateTime.Now.AddDays(10)
            },
             new Medicine()
            {
                Id = 2,
                Name = "M2",
               Brand = "ABC",
               Notes = "",
               Price = 10,
               Quantity = 10,
               ExpiryDate = DateTime.Now.AddDays(30)
            }
        };

        [TestInitialize]
        public void Initialize()
        {
            mockRepository = new Mock<IMedicineRepository>();

            _controller = new MedicinesController(mockRepository.Object);
        }

    }
}
