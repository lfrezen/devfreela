namespace DevFreela.Infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] data, string fileName);
    }
}
