# adg-shoppingcart

The solution tries to be simple and effective, while keeping the doors open for future development. 
The requirement is split in 2 subproblems:
  - how we calculate the price of an item that is bought n times
  - how we calculate the price of a Cart containing a list of such items (that can also contain "ABA" scenarios)

For each of the above problem, there is a service that solves it. Since the 2 concepts rely on each other, 
there must be a dependency between the two services. This dependency is highlighted by injecting the itemService 
(well, its interface) into the cartService.



_______________________________________________________________________

Due to using multiple offers the single offers could be deprecated. We still have the functionality for that working, so we 
don't break our callers, but we should enforce them to use the MultipleOffer for Single offers, too, as it can apply 
the best offer according to the saved amount, while using the combination will not provide the same flexibility. 
(See tests CalculateCartPriceUseBestAndMultipleAsSingleOfferTest and CalculateCartPriceSingleOfferAppliedLastTest)

