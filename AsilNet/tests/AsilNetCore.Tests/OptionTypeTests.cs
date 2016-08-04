namespace AsilNetCore.Tests
{
    using System;
    using Xunit;

    using AsilNet;
    using static AsilNet.Core;

    
    public class OptionTypeTests
    {
        [Fact]
        public void ShouldBeSome_IfEmployeeObjectIsNotNull()
        {
            var empName = "Tamil";
            var expected = new Employee(empName);
            var notNullEmployee = new Option<Employee>(new Tests.Employee(empName));            
            Assert.Equal<Employee>(expected, notNullEmployee.Value);
        }

        [Fact]
        public void ShouldBeSome_IfEmployeeObjectIsNotNull_InitWithSome()
        {
            var empName = "Tamil";
            var expected = new Employee(empName);
            var notNullEmployee = Some(new Employee(empName));
            Assert.Equal<Employee>(expected, notNullEmployee.Value);
        }

        [Fact]
        public void ShouldBeNone_IfEmployeeObjectIsNULL()
        {            
            Employee nullEmployee = null;
            var optEmployee = new Option<Employee>(nullEmployee);

            Assert.True(optEmployee.Equals(None));
        }
    }
}
