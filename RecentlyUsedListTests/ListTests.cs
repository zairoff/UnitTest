using RecentlyUsedList;
using System;
using Xunit;

namespace RecentlyUsedListTests
{
    public class ListTests
    {
        [Fact]
        public void Add_WhenInputNullOrEmpty_ShouldThrowException()
        {
            // Arrange
            var list = new List();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => list.Add(null));
        }

        [Fact]
        public void Add_WhenListIsFull_ShouldThrowException()
        {
            // Arrange
            var list = new List(1);

            // Act
            list.Add("1");

            // Act & Assert
            Assert.Throws<OverflowException>(() => list.Add("2"));
        }

        [Fact]
        public void Add_WhenListContainsDuplicateInput_ShouldThrowException()
        {
            // Arrange
            var list = new List();

            // Act
            list.Add("1");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.Add("1"));
        }

        [Fact]
        public void Add_WhenInputExpected_ListFirstItemShouldBeLastAdded()
        {
            // Arrange
            var list = new List();

            // Act
            list.Add("1");
            list.Add("2");
            list.Add("3");

            // Assert
            Assert.Equal("3", list[0]);
        }

        [Fact]
        public void Indexer_WhenIndexOutOfRange_ShouldThrowException()
        {
            // Arrange
            var list = new List();

            // Act & Assert 
            Assert.Throws<IndexOutOfRangeException>(() => list[6]);
        }

        [Fact]
        public void Indexer_WhenIndexExcpected_ShouldReturnItem()
        {
            // Arrange
            var list = new List();
            list.Add("1");

            // Act
            var result = list[0];

            // Assert 
            Assert.Equal("1", result);
        }
    }
}
