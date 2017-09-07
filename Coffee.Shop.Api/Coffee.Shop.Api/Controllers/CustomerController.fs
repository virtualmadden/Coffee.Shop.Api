namespace Coffee.Shop.Api.Controllers

open Microsoft.AspNetCore.Mvc
open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Coffee.Shop.Api.Models.Customers

[<Route("[controller]")>]
type CustomerController() = 
    inherit Controller()
    
    [<HttpGet>]
    member this.Get() = [| new Customer (Id = 3, First = "Jon", Last = "Doe") |]
    
    [<HttpGet("{id}")>]
    member this.Get(id : int) = "value"
    
    [<HttpPost>]
    member this.Post([<FromBody>] value : string) = ()
    
    [<HttpPut("{id}")>]
    member this.Put(id : int, [<FromBody>] value : string) = ()
    
    [<HttpDelete("{id}")>]
    member this.Delete(id : int) = ()
