# COMP2670_Final_Project
This Repo Contains all the code to the front-end GUI of our database. It was written in C#, using Visual Studio 2010 Professional , and interfaces with the database using the MySQL API's. The database it communicates to is currently setup to be on the computers localhost, but it can be configured to connect to any MySQL database, such as a linux NAS on the Wentworth Domain.

#How to install
In order to use this application, you must have the following additional software installed:
1. Microsoft .NET framework version 4 - https://www.microsoft.com/en-us/download/details.aspx?id=17851
2. MySQL and Appache - It is recommended to install these both through the application xampp - https://www.apachefriends.org/download.html

Follow the installer's prompts to complete each software's installation.

#How to run
1. Import the database into MySQL via phpMyAdmin
   a. navigate to "http://localhost/phpmyadmin"
   b. create a database called "cellphone"
   c. import the file "Part 4 physical design" into the cellphone database

2. Extract the zip file "Part 4 GUI release.zip" into a directory and run the exe.
   a. you can also use the zip file "Release.zip" in the repository directory bin/Release
   
You will see two files:
GameOfPhones.exe - The main GUI executable file.
MySql.Data.dll - The API's provided by MySQL to interface with the MySQL database.

#Application description
The Application is divided into 4 parts: the main window, the advanced search, the results page, and the full phone information page.
The main window is what the user is first presented with. From there, the user can either perform a quick search by entering keywords into the quick search box, or click the advanced search button to perform an advanced search. The quick search feature works by creating a dynamic search query to include every keyword entered by the user, assuming each keyword it separated by spaces. It then sends the query to the results window.

The advanced search first runs a series of "canned queries" to search for each possible attribute of a phone and its hardware that a user can search for. Some of these include the phone's internal storage capacity, price, display resolution, processor speed, and total RAM capacity. It loads each of these properties as an arraylist of phone properties, and fills each properties checkListBox. This enables the user to select one or more of each of the phone properties listed in the search window. The user can also sort by a series of possible sorting options from the "order by" drop down menu. Once the user presses search, it creates a dynamic query, specific to that user's specifications, and sends it to the results window.

The results window works first by finding all of the phone ID's produced by the dynamic query that was given to it by one of the above two windows. The search query returns a results in the form of a DataSet, which contains a ColumnCollection and RowCollection, which is an array of the columns and rows from the returned DataSet table, respectively. Further, each Row is an array of objects, representing all of the values of that row. The results window iterates through each Row for each value at index 0 (the phone id), casts it to an int, and adds it to a list of ints. The window then runs a dynamic query to select information of each phone. Only the information that goes into the results list is queried for. When it returns the DataSet of all the rows, it parses each value in each row into an arrayList of class Phone, and adds it to the results GUI Panel for that phone. Lastly, it adds each phone's GUI Panel to a table of phone results, and displays it.

Clicking on the blue link of the phone's name in the results page brings up the full phone information window. It acts similar to the results window, the difference being that it only displays information for one phone, and that it gathers all information about that phone. It is a canned query. The only part of the query that changes is at the end, where the Phone.phoneID changes. It does the same methods of running the query and parsing as the results window. The displaying of the phone information is similar, instead of putting the information into a phone results panel, it puts it into several different possible form controls, depending on what that data value is.