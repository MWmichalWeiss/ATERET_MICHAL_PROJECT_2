מערכת שעות
תיאור הפרויייקט:
מערכת לניהול שיעורים לתיכון. באמצעות המערכת ניתן לסדר מורות לשיעורים בכיתות ולנהל את כלל השיעורים בתיכון.
ישויות:
מורה
כיתה
שיעור
מיפוי routes למורה:
שליפת רשימת המורות .             GET  https://ATERETM.co .il/teachers
שליפת מורה לפי מזהה                    GET  https://ATERETM.co.il/teachers/1                
הוספת מורה  POST  https://ATERETM.co.il/teachers                                 
עדכון מורה  PUT  https://ATERETM.co.il/teachers/1                                  
מחיקת מורה  DELETE  https://ATERETM.co.il/teachers/1                         
שנות וותק  GET  https://ATERETM.co.il/teachers/1/                            
מיפוי routes לכיתה:
שליפת רשימת הכיתות GET  https://ATERETM.co.il/classes                           
שליפת כיתה לפי מזהה GET  https://ATERETM.co.il/classes/1                           
הוספת כיתה POST  https://ATERETM.co.il/classes                                          
מחיקת כיתה DELETE  https://ATERETM.co.il/classes/1                                  
עדכון כיתה PUT  https://ATERETM.co.il/classes/1                                         
מספר תלמידות בכיתה GET  https://ATERETM.co.il/classes/1/numStudent                          
מיפוי routes לשיעור:
שליפת רשימת השיעורים GET  https://ATERETM.co.il/lessons                         
שליפת שיעור לפי מזהה GET  https://ATERETM.co.il/lessons/1                         
הוספת שיעור POST  https://ATERETM.co.il/lessons                                         
מחיקת שיעור POST  https://ATERETM.co.il/lessons                                         
עדכון השיעור PUT  https://ATERETM.co.il/lessons/1                                         
עלות השיעור GET  https://ATERETM.co.il/lessons/1/lessonCost                                         

 
מורה – שם ,מקצוע, שנות וותק, 
כיתה- שכבה , מספר כיתה, מספר בנות בכיתה.
שיעור – שם המקצוע , מספר פעמים בשבוע , עלות שיעור
 

