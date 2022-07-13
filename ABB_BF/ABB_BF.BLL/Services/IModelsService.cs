namespace ABB_BF.BLL.Services
{
    public interface IModelsService
    {
        string FixPhoneNumber(string number);
        bool IsEmailValid(string email);
        bool IsNumberValid(string number);
    }
}