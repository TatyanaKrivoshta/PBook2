namespace PB.GUI.Viewmodels.Base;

public enum PhoneTypeEnum
{
    work = 1,
    home = 2,
    mobile = 3
}

public class BaseConnectedObject : ViewModelBase
{
    protected readonly ClientDAL Service = new ClientDAL();
}