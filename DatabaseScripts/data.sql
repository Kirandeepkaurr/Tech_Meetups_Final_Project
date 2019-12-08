INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0ca6f8d2-41ff-49d9-a754-083f562dcd02', N'frank@techmeetup.com', N'FRANK@TECHMEETUP.COM', N'frank@techmeetup.com', N'FRANK@TECHMEETUP.COM', 1, N'AQAAAAEAACcQAAAAEIedu69q0g2ALMt7iP3HFcC5PetVoFNbunzn06XMc6JeJNU8r9JeLVNScPebM4DgiA==', N'T6PWLLFYYX5UVF7Y4UM3R2LU5BFC4N4E', N'2d3d1485-dab0-4c15-9df5-ac7a660f4296', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'86d57a7a-f114-4488-b3a9-4c2a44cde51b', N'harris@techmeetup.com', N'HARRIS@TECHMEETUP.COM', N'harris@techmeetup.com', N'HARRIS@TECHMEETUP.COM', 1, N'AQAAAAEAACcQAAAAEELNngeOH7qeisWroBtiyCrmGgpxUUy6IKdzfz1eb+VjsTukb45WI967D9znNKxXtw==', N'SVPWRF424VWJVN7XD4UKK7D5SML3ZURH', N'f8b2fd31-302f-4d3e-8c78-b1bdb540bd5e', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a18bb196-ded6-400d-9e79-e111abf362da', N'david@techmeetup.com', N'DAVID@TECHMEETUP.COM', N'david@techmeetup.com', N'DAVID@TECHMEETUP.COM', 1, N'AQAAAAEAACcQAAAAEFrqZbdDYhyrZxPmYxy8hax6zDPds6OxQJk0Plx17EjqZb9h4XUOeypW2YOyMe11zA==', N'QS73WA7O2HHXZX7RLVB63E2AGZ5UTYRK', N'8e97caef-89e7-4cf6-bfaa-88db9d45b636', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0f058b84-c23b-49c6-9afb-8f2449b5790a', N'meetup_admin', N'meetup_admin', N'18862fff-e58c-42a7-9dcf-ecc474a97fb4')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'bf00c3d7-4569-49ed-94e0-f8a715db333a', N'participant', N'participant', N'39c90232-8d69-4f25-9571-175426182e72')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0ca6f8d2-41ff-49d9-a754-083f562dcd02', N'0f058b84-c23b-49c6-9afb-8f2449b5790a')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'86d57a7a-f114-4488-b3a9-4c2a44cde51b', N'bf00c3d7-4569-49ed-94e0-f8a715db333a')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a18bb196-ded6-400d-9e79-e111abf362da', N'bf00c3d7-4569-49ed-94e0-f8a715db333a')
SET IDENTITY_INSERT [dbo].[Meetup] ON
INSERT INTO [dbo].[Meetup] ([Id], [EventTitle], [Venue], [Date], [StartTime], [EndTime]) VALUES (1, N'Cloud Computing For Alliii', N'Grand Hotel', N'2019-11-20 00:00:00', N'2019-11-22 17:30:00', N'2019-11-22 19:30:00')
INSERT INTO [dbo].[Meetup] ([Id], [EventTitle], [Venue], [Date], [StartTime], [EndTime]) VALUES (2, N'Next Generation Web Apps', N'University of Auckland', N'2019-11-30 00:00:00', N'2019-11-22 18:00:00', N'2019-11-22 19:30:00')
INSERT INTO [dbo].[Meetup] ([Id], [EventTitle], [Venue], [Date], [StartTime], [EndTime]) VALUES (3, N'Internet of Things and the Cloud applications', N'Auckland University of Technology', N'2019-12-14 00:00:00', N'2019-11-22 09:30:00', N'2019-11-22 11:13:00')
INSERT INTO [dbo].[Meetup] ([Id], [EventTitle], [Venue], [Date], [StartTime], [EndTime]) VALUES (4, N'Robotics  Workshop', N'University of Auckland', N'2019-11-29 00:00:00', N'2019-11-22 10:00:00', N'2019-11-22 12:00:00')
INSERT INTO [dbo].[Meetup] ([Id], [EventTitle], [Venue], [Date], [StartTime], [EndTime]) VALUES (5, N'Software for Designing ', N'Grand Hotel', N'2019-11-20 00:00:00', N'2019-11-22 14:00:00', N'2019-11-22 16:00:00')
SET IDENTITY_INSERT [dbo].[Meetup] OFF
SET IDENTITY_INSERT [dbo].[Participant] ON
INSERT INTO [dbo].[Participant] ([Id], [Name], [Email], [Mobile]) VALUES (1, N'David Gosling', N'david@techmeetup.com', N'0217894567')
INSERT INTO [dbo].[Participant] ([Id], [Name], [Email], [Mobile]) VALUES (2, N'Harris Davidson', N'harris@techmeetup.com', N'0218901234')
SET IDENTITY_INSERT [dbo].[Participant] OFF
SET IDENTITY_INSERT [dbo].[MeetupRegistration] ON
INSERT INTO [dbo].[MeetupRegistration] ([Id], [MeetupId], [ParticipantId]) VALUES (2, 1, 1)
INSERT INTO [dbo].[MeetupRegistration] ([Id], [MeetupId], [ParticipantId]) VALUES (3, 4, 2)
INSERT INTO [dbo].[MeetupRegistration] ([Id], [MeetupId], [ParticipantId]) VALUES (4, 3, 2)
SET IDENTITY_INSERT [dbo].[MeetupRegistration] OFF
