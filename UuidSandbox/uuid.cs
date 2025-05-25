#:package Ulid@1.3.4

Guid id = Guid.CreateVersion7();

Console.WriteLine("Guid.CreateVersion7(): " + id);
Console.WriteLine("Guid.CreateVersion7().ToString(): " + id.ToString());

Ulid id2 = Ulid.NewUlid();
Console.WriteLine("Ulid.NewUlid(): " + id2);
Console.WriteLine("Ulid.NewUlid(): " + Ulid.NewUlid().ToString());
Console.WriteLine("Ulid.NewUlid(): " + Ulid.NewUlid().ToString());
Console.WriteLine("Ulid.NewUlid(): " + Ulid.NewUlid().ToString());
Console.WriteLine("Ulid.NewUlid(): " + Ulid.NewUlid().ToString());