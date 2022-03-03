# ACME COMPANY GILBERTH NUÑEZ

# Exercise
The company ACME offers their employees the flexibility to work the hours they want. But due to some external circumstances they need to know what employees have been at the office within the same time frame

The goal of this exercise is to output a table containing pairs of employees and how often they have coincided in the office.

Input: the name of an employee and the schedule they worked, indicating the time and hours. This should be a .txt file with at least five sets of data. You can include the data from our examples below:



|NAME   | SCHEDULE  |
| ------------ | ------------ |
|  RENE |  MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00- 21:00 |
|  ASTRID |  MO10:00-12:00,TH12:00-14:00,SU20:00-21:00 |
| ANDRES  |  MO10:00-12:00,TH12:00-14:00,SU20:00-21:00 |

# Architecture
The architecture used was: Component-based architecture, having the following classes: 
Schedule
Program

# Approach and Methodoloy

The solution was made by separating the different functionalities into components based on the problem. 
The **class Program ** which contains the functionalities of opening and closing a file, as well as the instance of a Schedule object.

The **class Schedule** which contains as attributes the days of the week declared as a bidimension list. This class contains the functions for processing input 

The **SplitName** function this function receives a string as a parameter, separates the name from the rest of the string, these values are stored in an array and calls the SplitWorkingDays function.

The **SplitWorkingDays** this function receives two parameters a string array and a string data, it goes through the string array separating the day from the hours worked and calls the IdentifySchedule function.

The **SplitHours** this function receives two parameters a string array and a string data, it goes through the string array separating the day from the hours worked and calls the IdentifySchedule function.

The **ValidateTime** this function receives as parameter the start time, end time, start minutes and end minutes, returns true if the schedule is valid or returns false if there is an error in any parameter.

# How to Run the Program.
The program is written in C# language, as a console application.
