--Request 3

select concat(first_name, ' ', last_name) as full_name, name from project
join employee on employee.project_id = project.id
where max_sum_rate <= (
	select sum(position.rate) from employee
	JOIN position on employee.position_id = position.id
	where project_id = project.id
	group by project_id
);