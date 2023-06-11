select rental_id, car_id, customer_id, km_driven from rentals 
where month (pickup_date) = '08' AND YEAR (pickup_date)='2019';