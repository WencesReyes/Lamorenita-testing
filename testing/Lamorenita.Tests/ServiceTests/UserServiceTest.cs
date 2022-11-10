using AutoMapper;
using Lamorenita.Data_Contexts;
using Lamorenita.Data_Entities;
using Lamorenita.Models;
using Lamorenita.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lamorenita.Tests.ServiceTests
{
    public class UserServiceTest
    {
        private readonly DbContextOptions<LamorenitaDbContext> _options;
        public UserServiceTest()
        {
            _options = new DbContextOptionsBuilder<LamorenitaDbContext>()
                .UseInMemoryDatabase("ProductServiceTest")
                .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;

            using var context = new LamorenitaDbContext(_options);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.AddRange(
                new UserEntity() { Id = 1, UserName = "wences", Password = "password1", FirstName= "wenceslao", LastName = "reyes", SecondLastName = "espinoza" }
            );

            context.SaveChanges();
        }

        [Fact]
        private async Task ShouldGetAllUserAsync()
        {
            //Arrange
            using var context = new LamorenitaDbContext(_options);

            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile<AutoMapperProfile>();
            }).CreateMapper();

            var service = new UserService(context, mapper);

            //Act

            var users = await service.getAllUsersAsync();

            //Verify

            Assert.NotNull(users);
        }
    }
}
