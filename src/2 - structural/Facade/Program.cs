

using Facade;

var travelPackageClient = new TravelPackageClient();


//TotalPackage
Console.WriteLine("==================Total Travel Package====================");
var totalPackage= travelPackageClient.GetTotalTravelPackage();
travelPackageClient.RequestFacade(totalPackage);

//BasicPackage
Console.WriteLine("==================Basic Travel Package====================");
var basicPackage = travelPackageClient.GetBasicTravelPackage();
travelPackageClient.RequestFacade(basicPackage);

Console.ReadLine();

