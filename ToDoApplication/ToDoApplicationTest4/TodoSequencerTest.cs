﻿using ToDoApplication.Data;
using Xunit;

namespace ToDoApplicationTest4
{
    public class TodoSequencerTest
    {
        [Fact]
        public void TodoSequencerSetId()
        {
            //Act
            TodoSequencer.nextToDoId();
            //Assert
            Assert.Equal(1, TodoSequencer.todoId);
        }

        [Fact]
        public void TodoSequencerReSetId()
        {
            //Act
            TodoSequencer.nextToDoId();
            TodoSequencer.nextToDoId();
            TodoSequencer.Reset();
            //Assert
            Assert.Equal(0, TodoSequencer.todoId);
        }
    }
}
