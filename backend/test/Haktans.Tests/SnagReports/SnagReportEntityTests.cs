using System;
using Xunit;
using FluentAssertions;
using Haktans.Entities;

namespace Haktans.Tests.SnagReports
{
    public class SnagReportEntityTests
    {
        [Fact]
        public void SnagReport_ShouldBeCreatable()
        {
            // Act
            var entity = new SnagReport();

            // Assert
            entity.Should().NotBeNull();
        }

        [Fact]
        public void SnagReport_ShouldHaveDefaultValues()
        {
            // Act
            var entity = new SnagReport();

            // Assert
            entity.Id.Should().Be(default(long));

        }

        [Fact]
        public void SnagReport_AtaChapter_ShouldAcceptValue()
        {
            var entity = new SnagReport { AtaChapter = "Test Value" };
            entity.AtaChapter.Should().Be("Test Value");
        }

        [Fact]
        public void SnagReport_Title_ShouldAcceptValue()
        {
            var entity = new SnagReport { Title = "Test Value" };
            entity.Title.Should().Be("Test Value");
        }

        [Fact]
        public void SnagReport_Description_ShouldAcceptValue()
        {
            var entity = new SnagReport { Description = "Test Value" };
            entity.Description.Should().Be("Test Value");
        }

        [Fact]
        public void SnagReport_ReporterName_ShouldAcceptValue()
        {
            var entity = new SnagReport { ReporterName = "Test Value" };
            entity.ReporterName.Should().Be("Test Value");
        }

    }
}
