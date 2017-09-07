namespace Coffee.Shop.Api.Tests.Models

open NUnit.Framework
open Coffee.Shop.Api.Models.Customers

module CustomersTests = 
    [<TestFixture>]
    type CustomerModelTests() = 
        [<Test>]
        member this.ShouldReturnValidCustomer() =
            let result = new Customer(Id = 3, First = "Jon", Last = "Doe")
            Assert.AreEqual(result.Id, 3)
            Assert.AreEqual(result.First, "Jon")
            Assert.AreEqual(result.Last, "Doe")
            