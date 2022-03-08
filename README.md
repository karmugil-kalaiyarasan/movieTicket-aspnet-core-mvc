# movieTicket-aspnet-core5-mvc

<h3>Live Link:<h3>

* Here is the live azure link for the website: https://movietickets-app.azurewebsites.net/

###Login Credentials###:

* To Login as a normal user use the following username and password,
  username: karmugil@gmail.com
  password: Code@1234?

* To Login as a admin user use the following username and password,
  username: admin@tickets.com
  password: Code@1234?

* When you are registering or creating a new user always use the password "Code@1234?"

###Payment:
*For the payment system I have created a developer sandbox accout so that you can pay using paypal without paying using real money. 
*On clicking paypal payment link a paypal payment tab will open which will ask for the paypal username and password. Please provide the below mentioned username and password to avoid any issues. The username and password for the paypal payment are,
  username: sb-xo7n214211704@personal.example.com
  password: 12345678
*Once you have logged into the paypal account on the payment method select the "Paypal Balance" option and then click pay now.

###Orders:
*There is an orders option available on the username dropdown where you can find all the orders.

###Show Details:
*On clicking show details option you can find the links for the Cinemas, Actors and Producers where you can see the details for that option and see all the cinemas, actors and producers available on this website by using show all button.

###Logout:
*On clicking logout the user will be logged out and taken to the home page of the website.


For the frontend I have used the Razor views and Bootstrap.
Used Azure SQL server for the database and Entity framework is used to create migrations for the database.
Created a base service and repositories for all the actions which can be reused under multiple controllers.
For payment integrated Paypal developer sandbox.
Have used authentication system for login process.
Added authorization to differentiate admin and normal user to create access layers based on the user privileges.
Deployed on Azure with the help of azure App services.
