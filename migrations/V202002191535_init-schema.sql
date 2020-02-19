create schema if not exists recipe collate latin1_swedish_ci;

create table if not exists Ingredient
(
	Id varchar(255) charset utf8mb4 not null
		primary key,
	Name longtext charset utf8mb4 null
);

create table if not exists Recipe
(
	Id varchar(255) charset utf8mb4 not null
		primary key,
	Name longtext charset utf8mb4 null,
	NumberOfPersons int null,
	ImageBase64 longtext charset utf8mb4 null
);

create table if not exists IngredientRecipe
(
	IngredientId varchar(255) charset utf8mb4 not null,
	RecipeId varchar(255) charset utf8mb4 not null,
	Unit longtext charset utf8mb4 null,
	Quantity int not null,
	primary key (IngredientId, RecipeId),
	constraint FK_IngredientRecipe_Ingredient_IngredientId
		foreign key (IngredientId) references Ingredient (Id)
			on delete cascade,
	constraint FK_IngredientRecipe_Recipe_IngredientId
		foreign key (RecipeId) references Recipe (Id)
			on delete cascade
);

create table if not exists Step
(
	Id varchar(255) charset utf8mb4 not null
		primary key,
	Number int not null,
	Description longtext charset utf8mb4 null,
	RecipeId varchar(255) charset utf8mb4 null,
	constraint FK_Step_Recipe_RecipeId
		foreign key (RecipeId) references Recipe (Id)
);

create index IX_Step_RecipeId
	on Step (RecipeId);

create table if not exists __EFMigrationsHistory
(
	MigrationId varchar(95) not null
		primary key,
	ProductVersion varchar(32) not null
);