--Request 4

select concat(first_name, ' ', last_name) as full_name, project.name, 
project.max_sum_rate - (position.rate + (sum(equipment.price / 12))) as diff
from employee e
join project on e.project_id = project.id
join position on e.position_id = position.id
join equipment on e.id = equipment.employee_id
where max_sum_rate <= 
	position.rate + (select (sum(equipment.price) / 12) from employee
	join equipment on employee.id = equipment.employee_id
	join position on employee.id = position.id
	where employee.id = e.id
	GROUP by employee.id)

group by first_name, last_name, project.name, position.rate, project.max_sum_rate;
