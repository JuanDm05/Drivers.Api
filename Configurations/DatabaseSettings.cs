namespace Drivers.Api.Configurations;


public class DatabaseSettings
{
    public string ConnectionsString {get;set;}= string.Empty;
    
    public string DatabaseName{get;set;}=string.Empty;

    public string CollectionName { get;set;}=string.Empty;

}
