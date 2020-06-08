# adg-shoppingcart

The solution tries to be simple and effective, while keeping the doors open for future development. 
The requirement is split in 2 subproblems:
  - how we calculate the price of an item that is bought n times
  - how we calculate the price of a Cart containing a list of such items (that can also contain "ABA" scenarios)

For each of the above problem, there is a service that solves it. Since the 2 concepts rely on each other, 
there must be a dependency between the two services. This dependency is highlighted by injecting the itemService 
(well, its interface) into the cartService.
