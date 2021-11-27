# Introduction
Calendar is a .NET C# windows form application. It's a simple calendar that have a **SQlite database** so all your data will be stored locally in your project's folder.
***please see 'Release Change' section below.***
I used a windows form application and a sqlite database because the application want to work offline and all the data want to remain in the owner computer.

## PROJECT STRUCTURE
 
- in the folder "Classes" you will find all the classes used.
- in the folder "Form" you will find all the windows form
- in the folder "UserControl" you will find all the UserControl needed in the Form

## OS Compatibility
- Windows OS fully compatible
- Linux/MAC OS *NOT* compatible

## Important
- When you load the project on visual studio it's possible that it will show this error: 
<em>'Couldn't process file resx due to its being in the Internet or Restricted zone or having the mark of the web on the file' </em>
- Fix Here: [StackOverflow](https://stackoverflow.com/questions/51348919/couldnt-process-file-resx-due-to-its-being-in-the-internet-or-restricted-zone-o)

## Release Change
- I will change the connection string from folder project to point to a shared folder so the data will also be accessible from another pc in the lan
- I'm going to to that in the first release patch because for development purpose I need the db in the folder bin/debug

### Authors details

- Andrea Cera email: **ndrcera@gmail.com** phone: 3495633130 

#### Changelogs

You can find the history of the project and update here: [GitHub](https://github.com/Arial-js/Calendar-.NET)
