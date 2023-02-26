using BusinessManagementApp.Common.Enums;


namespace BusinessManagementApp.Common.Interfaces
{
    public interface IResponse
    {
        public ResponseType ResponseType { get; set; }

        public string Message { get; set; }

    }
}
