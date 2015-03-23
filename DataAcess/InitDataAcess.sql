MERGE INTO Car AS Target 
USING (VALUES 
        (1, 'Corsa',2010,0,'KHJ-8484'), 
        (2, 'Astra',2011,0,'KHJ-8084')
) 
AS Source (Id, Model, Year, Mileage,Board) 
ON Target.Id = Source.Id 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Model, Year, Mileage, Board) 
VALUES (Model, Year, Mileage, Board) ;