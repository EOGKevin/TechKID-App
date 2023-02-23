using Firebase.Firestore;
using System;

[FirestoreData]
public struct Register
{
    [FirestoreProperty]
    public string fullname { get; set; }
    [FirestoreProperty]
    public string email { get; set; }
    [FirestoreProperty]
    public string Address { get; set; }
    [FirestoreProperty]
    public string Phone { get; set; }
    [FirestoreProperty]
    public DateTime birth { get; set; }

}
