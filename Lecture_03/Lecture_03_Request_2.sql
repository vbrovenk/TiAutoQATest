--Request 2

select name from project
where max_sum_rate <= (
	select sum(position.rate) from employee
	JOIN position on employee.position_id = position.id
	where project_id = project.id
	group by project_id
);
