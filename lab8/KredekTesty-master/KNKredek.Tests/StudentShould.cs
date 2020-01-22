using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace KNKredek.Tests
{
    public class StudentShould
    {
        private readonly ITestOutputHelper _stdOut;

        public StudentShould(ITestOutputHelper stdOut)
        {
            _stdOut = stdOut;

        }

        [Fact(Skip = "no nie wiem")]
        public void BeActiveWhenNew()
        {
            _stdOut.WriteLine("Checking student");
            Student sut = new Student(); // system under test

            Assert.True(sut.IsActive);
        }

        [Theory]
        [InlineData("Mirek", "Handlarz")]
        [InlineData("asdasd", "Handlarz")]
        [InlineData("sdsda", "Handlarz")]
        [InlineData("dsd", "")]
        [InlineData("asdw", "ss")]
        public void CalculateFullName(string firstName, string lastName)
        {
            Student sut = new Student(); // system under test

            sut.FirstName = firstName;
            sut.LastName = lastName;

            Assert.Equal(firstName +" "+ lastName , sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.EndsWith(" Student", sut.FullName);
        }
        [Fact]
        public void CalculateFullName_Contains()
        {
            Student sut = new Student();

            sut.FirstName = "Mirek";
            sut.LastName = "Handlarz";

            Assert.Contains("Mirek Ha", sut.FullName);
        }

        [Fact]
        public void CalculateStudentMotivation()
        {
            Student sut = new Student();

            Assert.Equal(100, sut.Motivation);
        }

        [Fact]
        public void CalculateStudentMotivation_NotInRange()
        {
            Student sut = new Student();


            Assert.NotInRange(sut.Motivation, 0 ,99);
        }

        [Fact]
        public void CalculateStudentMotivationAfterRest_InRange()
        {
            Student sut = new Student();

            sut.Rest();

            Assert.InRange(sut.Motivation, 101, 150);
        }

        [Fact]
        public void CalculateStudentMotivationAfterRest_True()
        {
            Student sut = new Student();
            
            sut.Rest();

            Assert.True(sut.Motivation >= 101 && sut.Motivation <= 150);
        }

        [Fact]
        public void HaveRandomIndex()
        {
            Student sut = new Student();

            sut.SetRandomIndexNumber();

            Assert.NotNull(sut.IndexNumber);
        }

        [Fact]
        public void RaiseRestEvent()
        {
            Student sut = new Student();

            Assert.Raises<EventArgs>(
                handler => sut.StudentRest += handler,
                handler => sut.StudentRest += handler,
                () => sut.Rest());
        }

        [Fact]
        public void RaisePropertyChangeEvent()
        {
            Student sut = new Student();

            Assert.PropertyChanged(sut, "Motivation", () => sut.TakeAllTheCodeIn2Hours());
        }
    }
}
