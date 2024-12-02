using System;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace MauiFirestore;

public class SampleModel
{
    [FirestoreProperty]
    public string Id { get; set; }


    [FirestoreProperty]
    public string Code { get; set; }


    [FirestoreProperty]
    public string Name { get; set; }

    public class FirestoreService
  {
    private readonly FirestoreService db;

    public FirestoreService(FirestoreService firestoreService)
    {
        db = firestoreService;
    }

    public async Task SaveDataAsync()
    {
        await db.SaveAsync();
    }

  }
}


