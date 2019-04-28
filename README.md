High School Interviews Software
===

## Project Setup
- First you will need to download all dependencies the project needs. Luckily being the best thing that ever happened to programming,     gradle does this all for you. Just enter the command in the project directory `.\gradlew downloadAll` and it should download all the nesessary dependecies and requirements.

# Getting started

- The program is easy to start of with, before handing out the software to other teachers or parents. It is recommended to first setup the login, the program has a local admin login from factory distribution with a Username & Password of  `admin` & `admin`. After this is complete you can change the local admin to your personal preference, but the program can also add login details for people in the data base under `Logins`. It's to be noted that to login to the software in offline mode you will need to use local admin. As the local admin is seperate from the Database.

- After this is completed the software can be altered to your desire. You can add parents to the data and it will automaticly place it inside a time slot for both the parents and the teachers.

# Quick Commands

## Adding
`./gradlew build`, `./gradlew :vision:build`, `./gradlew :voicerecognition:build`, or `./gradlew :machinelearning:build`,
Build will compile and get the code ready without deploying it. It will also run all automated tests, which is great for testing your code before it ever gets run on a robot (which also means you can build whenever)

## Deleting
`./gradlew :vision:deploy`, `./gradlew :voicerecognition:deploy`, or `./gradlew :machinlearning:deploy`  
Deploying will build your code (as above), and deploy it to the robot. You have to be connected to the robot for this to work. Just keep in mind that deploying _does not run any automated tests_.

## Updating
`./gradlew runVision`,`.\gradlew runVoice`,`.\gradlew runMachineLearning`
You can run the code on your local computer without needing a Raspberry Pi or Tinker Board to test on. As long as you have a webcam (for vision), you should be A OK.

