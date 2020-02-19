INSERT INTO Ingredient (Id, Name)
  VALUES ('d3aaaff0-ad3d-403b-ae93-67964fb267e8', 'pomme'),
          ('d3adaff0-ad3d-403b-ae93-67964fb267e8', 'pâte brisée'),
          ('d3adaff0-ad3d-403b-af93-67964fb267e8','sachet de sucre'),
          ('d3adaff0-ad3d-403b-ae93-67964fb267e9','sucre');

INSERT INTO Recipe (Id,Name,NumberOfPersons,ImageBase64) VALUES ('d3aaaff0-ad3d-403b-ae93-67964fb267c8','Tarte aux pommes',6,null),
          ('d3aaaff0-ad3d-403b-ae93-67964fb267c9','tiramisu',6,null);

INSERT INTO IngredientRecipe (IngredientId,RecipeId,Unit,Quantity)
  VALUES('d3aaaff0-ad3d-403b-ae93-67964fb267e8','d3aaaff0-ad3d-403b-ae93-67964fb267c8','unit',6),
        ('d3adaff0-ad3d-403b-ae93-67964fb267e8','d3aaaff0-ad3d-403b-ae93-67964fb267c8','unit',1),
        ('d3adaff0-ad3d-403b-af93-67964fb267e8','d3aaaff0-ad3d-403b-ae93-67964fb267c8','unit',1),
        ('d3adaff0-ad3d-403b-ae93-67964fb267e9','d3aaaff0-ad3d-403b-ae93-67964fb267c8','gramme',30);

INSERT INTO Step (Id,Number,Description,RecipeId)
  VALUES('d3adaff0-ad3d-443b-ae93-67964fb267e1',1,'Éplucher et découper en morceaux 4 Golden.','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e2',2,'Faire une compote : les mettre dans une casserole avec un peu d eau (1 verre ou 2). Bien remuer. Quand les pommes commencent à ramollir, ajouter un sachet ou un sachet et demi de sucre vanillé. Ajouter un peu d eau si nécessaire.','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e3',3,'Vous saurez si la compote est prête une fois que les pommes ne seront plus dures du tout. Ce n est pas grave s il reste quelques morceaux.','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e4',4,'Pendant que la compote cuit, éplucher et couper en quatre les deux dernières pommes, puis, couper les quartiers en fines lamelles (elles serviront à être posées sur la compote).','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e5',5,'Préchauffer le four à 210°C (thermostat 7).','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e6',6,'Laisser un peu refroidir la compote et étaler la pâte brisée dans un moule et la piquer avec une fourchette.','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e7',7,'Verser la compote sur la pâte et placer les lamelles de pommes en formant une spirale ou plusieurs cercles, au choix ! Disposer des lamelles de beurre dessus.','d3aaaff0-ad3d-403b-ae93-67964fb267c8'),
        ('d3adaff0-ad3d-443b-ae93-67964fb267e8',8,'Mettre au four et laisser cuire pendant 30 min max. Surveiller la cuisson. Vous pouvez ajouter un peu de sucre vanillé sur la tarte pendant que çà cuit pour caraméliser un peu.','d3aaaff0-ad3d-403b-ae93-67964fb267c8');

