using System.Globalization;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Newtonsoft.Json;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            //string jsonFile = File.ReadAllText(@"../../../Datasets/sales.json");
            string result = GetSalesWithAppliedDiscount(context);
            Console.WriteLine(result);
        }

        //Problem 9

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportSuppliersDto[] suppliersDtos = JsonConvert.DeserializeObject<ImportSuppliersDto[]>(inputJson);

            Supplier[] suppliers = mapper.Map<Supplier[]>(suppliersDtos);
            context.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}.";
        }

        //Problem 10
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();
            ImportPartsDto[] partsDtos = JsonConvert.DeserializeObject<ImportPartsDto[]>(inputJson);

            ICollection<Part> validParts = new List<Part>();

            foreach (var importPartsDto in partsDtos)
            {
                if (!context.Suppliers.Any(s => s.Id == importPartsDto.SupplierId))
                {
                    continue;
                }

                Part part = mapper.Map<Part>(importPartsDto);
                validParts.Add(part);
            }

            context.Parts.AddRange(validParts);
            context.SaveChanges();
            return $"Successfully imported {validParts.Count}.";
        }

        //Problem 11

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportCarDto[] carDtos = JsonConvert.DeserializeObject<ImportCarDto[]>(inputJson);

            ICollection<Car> cars = new List<Car>();

            ICollection<PartCar> partCars = new List<PartCar>();

            foreach (var carDTO in carDtos)
            {

                Car car = mapper.Map<Car>(carDTO);
                cars.Add(car);

                foreach (var partId in carDTO.PartsId.Distinct())
                {
                    PartCar partCar = new PartCar() { Car = car, PartId = partId };
                    partCars.Add(partCar);
                }

            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            context.PartsCars.AddRange(partCars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }

        //Problem 12

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportCustomerDto[] customerDtos = JsonConvert.DeserializeObject<ImportCustomerDto[]>(inputJson);

            Customer[] customers = mapper.Map<Customer[]>(customerDtos);
            context.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}.";
        }

        //Problem 13

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();
            ImportSaleDto[] saleDtos = JsonConvert.DeserializeObject<ImportSaleDto[]>(inputJson);
            ICollection<Sale> sales = new List<Sale>();

            foreach (var importSaleDto in saleDtos)
            {
                Sale sale = mapper.Map<Sale>(importSaleDto);
                sales.Add(sale);
            }
            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";
        }

        //Problem 14

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    IsYoungDriver = c.IsYoungDriver
                }).AsNoTracking().ToArray();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

        //Problem 15

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars.Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                }).AsNoTracking().ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        //Problem 16

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers.Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                }).AsNoTracking().ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        //Problem 17

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsParts = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TraveledDistance = c.TraveledDistance
                    },
                    parts = c.PartsCars.Select(pc => new
                    {
                        Name = pc.Part.Name,
                        Price = pc.Part.Price.ToString("f2"),
                    }).ToArray()
                }).AsNoTracking().ToArray();

            return JsonConvert.SerializeObject(carsParts, Formatting.Indented);
        }

        //Problem 18

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customersWithCars = context.Customers
                .Where(c => c.Sales.Count > 0)
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count,
                    //spentMoney = 0,
                    CARS = c.Sales
                        .Select(s => new
                        {
                            carName = s.Car.Model,
                            PARTS = s.Car.PartsCars
                                .Select(pc => new
                                {
                                    partName = pc.Part.Name,
                                    PRICES = pc.Part.Price,
                                })
                                .ToArray()
                                .Sum(p => p.PRICES)
                        })
                        .ToArray(),
                })
                .ToArray();

            var data = customersWithCars
                .Select(c => new
                {
                    fullName = c.fullName,
                    boughtCars = c.boughtCars,
                    spentMoney = c.CARS.Sum(c => c.PARTS)
                })
                .OrderByDescending(x => x.spentMoney)
                .ThenByDescending(x => x.boughtCars)
                .ToArray();

            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        //Problem 19

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Take(10)
                .Select(s => new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    customerName = s.Customer.Name,
                    discount = s.Discount.ToString("f2"),
                    price = s.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("f2"),
                    priceWithDiscount = (s.Car.PartsCars.Sum(pc => pc.Part.Price) * (1 - s.Discount / 100)).ToString("F2")

                }).AsNoTracking().ToArray();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }




        private static IMapper CreateMapper()
        {
            return new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            }));
        }
    }
}