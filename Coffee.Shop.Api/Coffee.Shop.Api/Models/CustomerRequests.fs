namespace Coffee.Shop.Api.Models

open Coffee.Shop.Api.Models.Customers

module CustomerRequests = 
    type AddCustomerRequest = {
        First : string
        Last : string
    }
    
    type UpdateCustomerRequest = {
        First : string
        Last : string
    }