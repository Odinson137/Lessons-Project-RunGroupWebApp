using CloudinaryDotNet.Actions;

namespace RunGroupWebApp.Data.Interfaces
{
    public interface IPhotoServise
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
