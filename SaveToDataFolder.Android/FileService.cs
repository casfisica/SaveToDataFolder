using Android.App;
using SaveToDataFolder.Droid;
using SaveToDataFolder.Interface;
using System.IO;


[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace SaveToDataFolder.Droid
{
    public class FileService : IFileService
    {
        public string GetRootPath()
        {
            return Application.Context.GetExternalFilesDir(null).ToString();
            
        }
        public void CreateFile(string textMessage)
        {
            //throw new NotImplementedException();
            string filename = "test-file.txt";
            string destination = Path.Combine(GetRootPath(), filename);

            File.WriteAllText(destination, textMessage);
        }
    }
}