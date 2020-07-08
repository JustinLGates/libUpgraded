namespace upgradedlibrary.Interfaces
{
  public interface ICheckOut
  {
    bool CheckedOut { get; set; }
    void CheckOut();
    void Return();
  }
}