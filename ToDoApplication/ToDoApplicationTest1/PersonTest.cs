﻿using System.Collections.Generic;
using ToDoApplication.Models;
using Xunit;

namespace ToDoApplicationTest1
{
    public class PersonTest
    {
        [Fact]
        public void PersonClassSetValues()
        {
            //Arrange
            int personId = 1;
            string firstName = "navya";
            string lastName = "nidamanuri";
            //Act
            Person person = new Person(1,"navya","nidamanuri");
            //Assert
            Assert.Equal(personId, person.personId);
            Assert.Equal(firstName,person.firstName);
            Assert.Equal(lastName,person.lastName);
        }
    }
}
