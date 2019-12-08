1. Open the Solution in Visual Studio
2. Build the project 
3. Navigate to tools ans select Nuget Package manager -> Package Manager Console (PMC)
4. On the console execute the following command
Update-Database -Context Tech_Meetups_IdentityContext



5. On the console execute the following command

Update-Database -Context Tech_Meetups_DataContext



6. After migration is successful Run the project 

7 if you login as admin  from the following credentials will be able to see the Participants,  
Meetups and Meetup registrations and Enrolments Links. Note only admin can manage  meetups 
User : frank@techmeetup.com
Password: 1qaz2wsX@

8. Also you can login with the following credentials to visit the site as a Participant
 will be able to see and confrm participation to meet ups. Also log out and login if you encounter issues
 when confirming participation after a reboot of the web application as the participant id is inside an HTTP  session .The participant id is only
 populated during the Login and code for this can be found in Areas/Identity/Pages/Account/Login.cshtml.cs

 User : david@techmeetup.com
Password: 1qaz2wsX@



9 if you need to create another meetup  admin login with the admin credentials on step 7 above and
Click in "REGISTER a meet up admin" register a new admin 

10 . The admin can view delete and edit the meetups, participats and meetup registrations 



The identity  authentication code used in the project were obtained by following URLS

Introduction to Identity on ASP.NET Core
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.0&tabs=visual-studio
