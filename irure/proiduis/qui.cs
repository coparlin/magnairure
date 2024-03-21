using (var context = new YourDbContext())
{
    // Example operation: Adding a new entity
    var newEntity = new YourEntity { /* Set properties */ };
    context.YourEntities.Add(newEntity);
    
    // Nothing is saved to the DB until this is called
    context.SaveChanges();
}
