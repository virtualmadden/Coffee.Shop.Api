namespace Coffee.Shop.Api.Models

module CustomerRequests = 
    type AddCustomerRequest = {
        First : string
        Last : string
    }
    
    type UpdateCustomerRequest = {
        First : string
        Last : string
    }