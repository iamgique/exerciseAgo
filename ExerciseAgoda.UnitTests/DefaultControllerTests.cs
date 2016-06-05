using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ExerciseAgoda.Controllers;
using ExerciseAgoda.Repository;
using System.Data.SqlClient;
using Moq;
using NUnit.Framework;

namespace ExerciseAgoda.UnitTests
{

    [TestClass]
    public class DefaultControllerTests
    {
        private readonly IHotelRepository repository;

        [SetUp]
        public void Init()
        {
            
        }

        [Test]
        public void TestDepartmentCreateErrorView()
        {
            var container = new SimpleInjector.Container();
            container.Register<IHotelRepository, HotelRepository>();
            container.RegisterDecorator(typeof(IHotelRepository), typeof(DefaultController));

            var hotelService = container.GetInstance<IHotelRepository>();
            var hotelList = hotelService.fetchHotels();
            
        }

    }
}
