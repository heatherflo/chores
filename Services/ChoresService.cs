
namespace chores.Services;


public class ChoresService(ChoresRepository repo)
{

  private readonly ChoresRepository repo = repo;


  internal List<Chore> GetChores()
  {
    List<Chore> chores = repo.GetChores();
    return chores;
  }
  internal Chore GetChoreById(string choreId)
  {
    Chore chore = repo.GetChoreById(choreId);
    if (chore == null) throw new Exception($"go get busy,{choreId} is not available now");
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = repo.CreateChore(choreData);
    return chore;
  }

  internal string RemoveChore(string choreId)
  {
    Chore choreToRemove = GetChoreById(choreId);
    repo.RemoveChore(choreId);
    return $"{choreToRemove.Name} is already done";
  }
}