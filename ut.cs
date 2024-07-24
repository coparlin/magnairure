// Assuming contentItemManager.Delete method returns a Task or Task<T>
// and the method signature is async Task Delete(int contentItemId, string languageName)

try
{
    await contentItemManager.Delete(contentItemId.First(), languageName);
    Console.WriteLine("Content item deleted successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
