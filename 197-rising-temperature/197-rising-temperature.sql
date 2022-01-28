/* Write your T-SQL query statement below */
Select w1.id as 'id'
from Weather w1
inner join Weather w2 on w1.recordDate = DATEADD(day, 1, w2.recordDate)
where w1.temperature > w2.temperature


