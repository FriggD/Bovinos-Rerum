-- ----------------------------------------------------------------------------------------------------
DELETE FROM bosfactory
WHERE  heranca = 'Animal.RPOObject';

INSERT INTO bosfactory
            (clid,
             clname,
             bos,
             col,
             heranca)
VALUES      (0,
             'Animal',
             'Bovinos::application.bos.Animal',
             'Bovinos::application.col.ColAnimal',
             'Animal.RPOObject'); 
-- ----------------------------------------------------------------------------------------------------