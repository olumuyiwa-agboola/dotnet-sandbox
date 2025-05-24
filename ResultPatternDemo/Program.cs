using ResultPatternDemo;

Console.WriteLine("****** Trying out result generation ******");

var person = new Person("Olumuyiwa", "Agboola");
var successfulPersonResult = ResultOfType<Person>.Success(person);
var failedPersonResult = ResultOfType<Person>.Failure(ErrorType.InvalidInput, "Person already exists");

Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
Console.WriteLine($"Successful Person Result:\n\tValue: {successfulPersonResult.Value}\n\tErrorType: {successfulPersonResult.Error?.Type}\n\tErrorMessage: {successfulPersonResult.Error?.Message}\n\tIsSuccessful: {successfulPersonResult.IsSuccessful}");
Console.WriteLine($"Failed Person Result:\n\tValue: {failedPersonResult.Value}\n\tErrorType: {failedPersonResult.Error?.Type}\n\tErrorMessage: {failedPersonResult.Error?.Message}\n\tIsSuccessful: {failedPersonResult.IsSuccessful}");
