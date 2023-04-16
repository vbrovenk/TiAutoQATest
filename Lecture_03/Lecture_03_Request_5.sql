--Request 5

go
create trigger add_new_project
on project
after insert
as
insert into vacancies values ((select id from position where name = 'PM'));

enable trigger add_new_project on project;

insert into project values ('test', 1000);