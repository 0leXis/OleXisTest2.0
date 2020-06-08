/* Раскомментируйте строку ниже для ручного выполнения скрипта */
/* delimiter $ */
drop procedure if exists CheckLoginInfo$

Create procedure CheckLoginInfo(login varchar(50), password varchar(256))
begin
    Select u.id, u.name, u.surname, ug.name as rolename, u.UserGroup, sg.name 
    from users as u, usergroups as ug, studentgroups as sg 
    where u.login = login and u.password = password and u.UserGroup = ug.id and sg.id = u.StudentGroup 
    union 
    Select u.id, u.name, u.surname, ug.name as rolename, u.UserGroup, null from users as u, usergroups as ug 
    where u.login = login and u.password = password and u.UserGroup = ug.id and u.StudentGroup is null;
end$


drop procedure if exists GetStudentGroup$

Create procedure GetStudentGroup(studentGroup varchar(10))
begin
    Select id from studentgroups where name = studentGroup;
end$


drop procedure if exists CheckUserLogin$

Create procedure CheckUserLogin(userLogin varchar(50))
begin
    Select Count(login) from users where login = userLogin;
end$


drop procedure if exists RegisterStudent$

Create procedure RegisterStudent(userName varchar(50), userSurname varchar(50), userLogin varchar(50), userPassword varchar(256), studentGroup int)
begin
    Insert into users values(null, userName, userSurname, userLogin, userPassword, 2, studentGroup);
end$


drop procedure if exists RegisterTeacher$

Create procedure RegisterTeacher(userName varchar(50), userSurname varchar(50), userLogin varchar(50), userPassword varchar(256))
begin
    Insert into users values(null, userName, userSurname, userLogin, userPassword, 3, null);
end$


drop procedure if exists GetCreatorIdAndLastTestNumber$

Create procedure GetCreatorIdAndLastTestNumber(testName varchar(100))
begin
    Select (select Creator from tests where testName = Name) as Creator, (SELECT AUTO_INCREMENT FROM information_schema.tables WHERE TABLE_NAME = 'tests' AND table_schema = 'testsserver') as ID;
end$


drop procedure if exists SaveTest$

Create procedure SaveTest(testName varchar(100), creator int, subject int)
begin
    Insert into tests values(null, testName, creator, NOW(), subject, false);
end$


drop procedure if exists GetSubjectList$

Create procedure GetSubjectList()
begin
    Select * from subjects;
end$


drop procedure if exists GetRolesList$

Create procedure GetRolesList()
begin
    Select * from usergroups;
end$


drop procedure if exists GetUserRole$

Create procedure GetUserRole(UserId int)
begin
    Select usergroup from users where id = UserId;
end$


drop procedure if exists CheckSubject$

Create procedure CheckSubject(subjectName varchar(100))
begin
    Select * from subjects where name = subjectName;
end$


drop procedure if exists AddSubject$

Create procedure AddSubject(subjectName varchar(100))
begin
    Insert into subjects values(null, subjectName);
end$


drop procedure if exists CheckGroup$

Create procedure CheckGroup(subjectName varchar(10))
begin
    Select * from studentgroups where name = subjectName;
end$


drop procedure if exists AddGroup$

Create procedure AddGroup(groupName varchar(10))
begin
    Insert into studentgroups values(null, groupName);
end$


drop procedure if exists GetUserTests$

Create procedure GetUserTests(UserId int)
begin
    Select name from tests where Creator = UserId;
end$


drop procedure if exists GetAvailableTests$

Create procedure GetAvailableTests()
begin
    Select name from tests where PassAvailable = true;
end$


drop procedure if exists CheckTestCreator$

Create procedure CheckTestCreator(TestName varchar(100))
begin
    Select id, Subject, Creator from tests where Name = TestName;
end$


drop procedure if exists CheckTestCreatorId$

Create procedure CheckTestCreatorId(TestId int)
begin
    Select Creator from tests where id = TestId;
end$


drop procedure if exists PassToggle$

Create procedure PassToggle(TestId int)
begin
    if((select PassAvailable from tests where id = TestId) = false) then
		update tests set PassAvailable = true where id = TestId;
	else
		update tests set PassAvailable = false where id = TestId;
	end if;
end$


drop procedure if exists DeleteTest$

Create procedure DeleteTest(TestId int)
begin
	delete from testresults where test = TestId;
    delete from tests where id = TestId;
end$


drop procedure if exists DeleteUser$

Create procedure DeleteUser(UserId int)
begin
	if((Select usergroup from users where id = UserId) = 2) then
		delete from testresults where student = UserId;
	else
		delete from testresults where test in (select id from tests where creator = UserId);
		delete from tests where creator = UserId;
    end if;
    delete from users where id = UserId;
end$


drop procedure if exists CheckTestAvailability$

Create procedure CheckTestAvailability(TestName varchar(100))
begin
    Select id, Subject, PassAvailable from tests where Name = TestName;
end$


drop procedure if exists GetUsersSheet$

Create procedure GetUsersSheet(UserSurname varchar(50), UserRole int, UseSurnameFilter bool, UseRoleFilter bool)
begin
	if(UseSurnameFilter and UseRoleFilter) then
		Select u.id, u.Login, u.Name, u.Surname, u.UserGroup, sg.Name from users as u left join studentgroups as sg on sg.id = u.StudentGroup where u.Surname like concat('%', UserSurname, '%') and u.UserGroup = UserRole;
    elseif(UseSurnameFilter) then
		Select u.id, u.Login, u.Name, u.Surname, u.UserGroup, sg.Name from users as u left join studentgroups as sg on sg.id = u.StudentGroup where u.Surname like concat('%', UserSurname, '%');
	elseif(UseRoleFilter) then
		Select u.id, u.Login, u.Name, u.Surname, u.UserGroup, sg.Name from users as u left join studentgroups as sg on sg.id = u.StudentGroup where u.UserGroup = UserRole;
	else
		Select u.id, u.Login, u.Name, u.Surname, u.UserGroup, sg.Name from users as u left join studentgroups as sg on sg.id = u.StudentGroup;
	end if;
end$


drop procedure if exists GetTestsSheet$

Create procedure GetTestsSheet(TestName varchar(100), TestSubject int, UseNameFilter bool, UseSubjectFilter bool)
begin
	if(UseNameFilter and UseSubjectFilter) then
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Name like concat('%', TestName, '%') and t.Subject = TestSubject;
    elseif(UseNameFilter) then
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Name like concat('%', TestName, '%');
	elseif(UseSubjectFilter) then
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Subject = TestSubject;
	else
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id;
	end if;
end$


drop procedure if exists GetTestResultSheet$

Create procedure GetTestResultSheet(UserSurname varchar(50), PassDate date, UseSurnameFilter bool, UseDateFilter bool)
begin
	if(UseSurnameFilter and UseDateFilter) then
		Select tr.id, concat(u.Surname, ' ', u.Name) as StudentData, tr.Mark, tr.PassingTime, tr.Date from testresults as tr left join users as u on tr.Student = u.id where u.Surname like concat('%', UserSurname, '%') and tr.Date = PassDate;
    elseif(UseSurnameFilter) then
		Select tr.id, concat(u.Surname, ' ', u.Name) as StudentData, tr.Mark, tr.PassingTime, tr.Date from testresults as tr left join users as u on tr.Student = u.id where u.Surname like concat('%', UserSurname, '%');
	elseif(UseDateFilter) then
		Select tr.id, concat(u.Surname, ' ', u.Name) as StudentData, tr.Mark, tr.PassingTime, tr.Date from testresults as tr left join users as u on tr.Student = u.id where tr.Date = PassDate;
	else
		Select tr.id, concat(u.Surname, ' ', u.Name) as StudentData, tr.Mark, tr.PassingTime, tr.Date from testresults as tr left join users as u on tr.Student = u.id;
	end if;
end$


drop procedure if exists GetTestsCreatorSheet$

Create procedure GetTestsCreatorSheet(CreatorId int, TestName varchar(100), TestSubject int, UseNameFilter bool, UseSubjectFilter bool)
begin
	if(UseNameFilter and UseSubjectFilter) then
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Name like concat('%', TestName, '%') and t.Subject = TestSubject and t.Creator = CreatorId;
    elseif(UseNameFilter) then
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Name like concat('%', TestName, '%') and t.Creator = CreatorId;
	elseif(UseSubjectFilter) then
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Subject = TestSubject and t.Creator = CreatorId;
	else
		Select t.id, t.Name, concat(u.Name, ' ', u.Surname) as TestCreator, t.EditDate, t.Subject, t.PassAvailable from tests as t left join users as u on t.Creator = u.id where t.Creator = CreatorId;
	end if;
end$


drop procedure if exists EditUser$

Create procedure EditUser(UserId int, UserName varchar(50), UserSurname varchar(50), UserPassword varchar(256), stGroup int, ChangePassword bool, ChangeGroup bool)
begin
	if(ChangePassword and ChangeGroup) then
		Update users set Name = UserName, Surname = UserSurname, Password = UserPassword, StudentGroup = stGroup where id = UserId;
	elseif(ChangeGroup) then
		Update users set Name = UserName, Surname = UserSurname, StudentGroup = stGroup where id = UserId;
    elseif(ChangePassword) then
		Update users set Name = UserName, Surname = UserSurname, Password = UserPassword where id = UserId;
    else
		Update users set Name = UserName, Surname = UserSurname where id = UserId;
    end if;
end$


drop procedure if exists ChangePassword$

Create procedure ChangePassword(UserId int, UserPassword varchar(256))
begin
	Update users set Password = UserPassword where id = UserId;
end$


drop procedure if exists AddTestResult$

Create procedure AddTestResult(TestId int, StudentId int, Mark int, PassingTime time, result blob)
begin
	Insert into testresults values (null, TestId, StudentId, Mark, PassingTime, NOW(), result);
end$


drop procedure if exists GetExtendedResult$

Create procedure GetExtendedResult(ResultId int)
begin
    Select Result from testresults where ResultId = id;
end$

drop procedure if exists GetExtendedResultSheet$

Create procedure GetExtendedResultSheet(TestId int)
begin
    Select tr.id, concat(u.Surname, ' ', u.Name) as StudentData, tr.Mark, tr.PassingTime, tr.Date, tr.Result from testresults as tr left join users as u on tr.Student = u.id where TestId = Test;
end$