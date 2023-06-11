SELECT DISTINCT USERS. NAME, USERS. ADDRESS FROM USERS, BOOKINGDETAILS
WHERE USERS.USER_ID=BOOKINGDETAILS.USER_ID AND USERS.USER_ID NOT IN 
(SELECT BOOKINGDETAILS.USER_ID FROM BOOKINGDETAILS WHERE BOOKINGDETAILS.NAME = 'HDFC')
ORDER BY USERS.NAME;