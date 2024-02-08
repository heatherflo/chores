




namespace chores.Repositories;


public class ChoresRepository
{
  private readonly List<Chore> FAKEDB = [
    new Chore("toilets", true, false, 20),
  new Chore("rake leaves", true, true, 120),
  new Chore("dust", false, false, 10),
];


  internal List<Chore> GetChores()
  {
    return FAKEDB;
  }
  internal Chore GetChoreById(string choreId)
  {
    Chore chore = FAKEDB.Find(chore => chore.Id == choreId);
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    FAKEDB.Add(choreData);
    return choreData;
  }

  internal void RemoveChore(string choreId)
  {
    int indexToRemove = FAKEDB.FindIndex(chore => chore.Id == choreId);
    FAKEDB.RemoveAt(indexToRemove);
  }
}