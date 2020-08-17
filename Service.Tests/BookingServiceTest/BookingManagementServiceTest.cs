﻿using System;
using System.Collections.Generic;
using System.Text;
using DB.Entity;
using NUnit.Framework;
using Service.BookingService.Realization;
using Service.Tests.TestSettings;
using Service.Tests.TestSettings.TestCases;
using Service.Tests.TestSettings.TestCases.BookingService;

namespace Service.Tests.BookingServiceTest
{
    class MyBookingManagementTest
    {
        private RepositoryMockResult mockResult;
        private BookingManagementService bookingManagementService;

        public void Setup(IList<User> users = null,  IList<Desk> desks = null, IList<Room> rooms = null,IList<Order> orders = null)
        {
            var repositoryDescriptor = new RepositoryDescriptor()
            {
                Users = users,
                Rooms = rooms,
                Desks = desks,
                Orders = orders
            };

            mockResult = ServiceTestHelper.MockRepository(repositoryDescriptor);

            bookingManagementService = new BookingManagementService(mockResult.UnitOfWorkMock.Object);
        }

        [Test, TestCaseSource(typeof(BookingManagementTestCase), nameof(BookingManagementTestCase.CreteTestCase))]
        public bool CreateBooking_CreteTestCase(IList<User> users, IList<Desk> desks,
                                                IList<Room> rooms, IList<Order> orders)
        {
            Setup(users, desks, rooms, orders);

            var result = bookingManagementService.CreateBooking(2, 2, DateTime.Today);

            return result;
        }

        [Test, TestCaseSource(typeof(BookingManagementTestCase), nameof(BookingManagementTestCase.CancelTestCase))]
        public bool CancelBooking_CancelTestCase(IList<User> users, IList<Desk> desks,
            IList<Room> rooms, IList<Order> orders)
        {
            Setup(users, desks, rooms, orders);

            var result = bookingManagementService.СancelBooking(users == null ? 0 : 1, 1);
            return result;
        }
    }
}
