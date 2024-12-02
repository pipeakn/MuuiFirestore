using Google.Cloud.Firestore;

namespace MauiFirestore.Services;

public class FirestoreService
{
 private FirestoreDb db;
    public string StatusMessage;

    public FirestoreService()
    {
        this.SetupFireStore();
    }
      private async Task SetupFireStore()
    {
        if (db == null)
        {
            var stream = await FileSystem.OpenAppPackageFileAsync("dx212-akaranont-firebase-adminsdk-tj73d-83976b0c97.json");
            var reader = new StreamReader(stream);
            var contents = reader.ReadToEnd();
            db = new FirestoreDbBuilder
            {
                ProjectId = "dx212-akaranont",

                JsonCredentials = contents
            }.Build();
        }
    }

}
