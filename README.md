# Blinds Steps to Run the solution:

Prerequisite: The solution is designed to run on Visual Studio 2015 or Later.
-----------------------------------------------------------------------------
1. After the checkout, Build the project and make sure all the NUGET packages/dependencies are installed properly.

2. Once the project is successfully build, Open the test explorer (VS Menu > Test > Test Window > Test Explorer)

3. Locate the test in the test explorer window, Right click and RUN the selected test.


Verify the logic for sorting the product in ascending order works:
------------------------------------------------------------------
One can comment the line number "43" on "VerifyBlindsSearch.CS" file, this will skip performing the click on "Sort By: Price Low to high" while running the test hence the test should fail due to the assertion/verification step which is designed to validate the prices in ascending order.
