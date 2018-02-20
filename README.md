# EfProjectionProblemSample
this is a sample project to show entity framework projection problem with extern alias


We've created one shared project and two .net standard projects which have reference to that shared project.

This is a project structure:

1- Model (Shared Project) partial class Customer { Id, FirstName, LastName } // in Objects namespace

2- Dto (.NET Standard Project) partial class Customer { FullName } // in Objects namespace

3- Entity (.NET Standard Project)

In shared project, we developed "Customer" class as a partial C# class with properties shared between Dto & Entity.

Then in Dto project, we added FullName as a extra property to Customer class.

We added "Data" project with Entity framework full and at there we added Customer as a DbSet called "Customers".

In our "Api" we returned 

```

dbContext.Set<EntityAlias.Objects.Customer>().Select(c => new DtoAlias.Objects.Customer
{
  Id = c.Id,
  FullName = string.Concat(c.FirstName,c.LasttName)
}).ToListAsync();

```

Sadly Entity Framework wasn't able to handle this kind of projection )-:

Note that this works fine in Ef Core.
