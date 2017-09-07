namespace Coffee.Shop.Api.Models

module Customers = 
    type Customer = 
        struct
            val mutable Id : int
            val mutable First : string
            val mutable Last : string
            new(id : int, first : string, last : string) = {
                Id = id;
                First = first;
                Last = last
            }
        end