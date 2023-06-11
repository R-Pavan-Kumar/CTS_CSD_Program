select s.student_name, d. department_name from Department d 
inner join Student s on d. department_id=s.department_id 
where s.city= 'Coimbatore'
order by s.student_name