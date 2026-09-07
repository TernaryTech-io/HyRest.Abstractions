namespace HyRest.Hyland.IdentityAdministration;

public interface IBaseStruct
{
    string Name { get; }
    abstract static IBaseStruct? MapByValue(string value);
}