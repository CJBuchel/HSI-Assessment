High School Interviews Software
===

Assumed to be given to Teachers and parents at school
And Assumed to be read on github @ `https://github.com/CJBuchel/HSI-Assessment` 

## Project Setup
- To set up the program first import the included sql file named `ImportMe.sql` to a database named `skynet` (you can delete later) and startup the database on the default port of 3306. Once complete you can click the setup icon in the directory. This wil download the GUI to your StartMenu, it should also start it automatically. And your done :)

# Getting started

## Navigating the Program
- The program is easy to start of with, before handing out the software to other teachers or parents. It is recommended to first setup the login, the program has a local admin login from factory distribution with a Username & Password of  `admin` & `admin`. After this is complete you can change the local admin to your personal preference.

### Add User
- The program can also add login details for Teachers or Parents And it can only be seen by the admin. (Depending on the latter it would only show Interview Data and Interview Times) in the data base under `Add Users`. It's to be noted that to login to the software in offline mode you will need to use local admin. As the local admin is seperate from the Database Users

### Add Data
- To add data to the database you can select `Add Data` on the main page. You can Then add the data to the data base, it should also link Teachers with Teacher codes and auto complete the information not listed. (`Not Done because it's demo software`)

### Interview Data
- Under Interview Data you can view all the data associated with the interviews, bar the start times. Using the searchbar at the top you can search through all the data. And ff you are logged in as a local admin you can edit the data in the grid for fixing issues or miss matched times for interviews.

### Interview Times 
- Under Interview Times is the main data for both parents and teachers using the program. It gives the Times of the interview the interview number and the teacher name Parent name and student name. And by default the software gives all teachers a start time of `5:00pm` and 5 minute intervals for each interview automatically. (`Not Done becuase it's demo software`)

### Users
- The Users tab is only seen by the local admin and gives the data for all users weather they are parent or teacher (Parent having limited access. only to view interview data and times. Teacher can edit interview times. And Admin can do both while also being able to see and edit the user data)

- After this is completed the software can be altered to your desire. You can add parents to the data and it will automatically place it inside a time slot for both the parents and the teachers.


# Deleting

- After viewing the software and most likly the importme.sql you can uninstall the gui from the start menu. it should just be named `GUI` and you can delete any other files associated with the program.

p.s give me extra marks. And you too can own your very own Interview times GUI

