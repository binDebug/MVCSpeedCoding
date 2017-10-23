using Speedcoding.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Repository
{
    public class Repository
    {
        public Repository()
        {
        }

        public Person GetPerson()
        {
            Person person = null;

            return person;
        }

        private void PopulatePersonDetails(Person person)
        {
            if (person == null)
                person = new Person();

            person.ID = 1;
            person.FirstName = "Melissa";
            person.LastName = "Crosby";
            person.About = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients."
                + "\n" +
                "My objective is to establish relationships for life, not just for the current transaction.I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting.";
            person.Brokerage = "Berkshire Hathaway HomeServices Elite Real Estate";
            person.Specialties = new List<string>();
            person.Specialties.Add("Property Management");
            person.Specialties.Add("Buyer’s Agent");
            person.Specialties.Add("Listing Agent");
            person.Specialties.Add("Another speciality");
            person.LicenseNumbers = new List<string>();
            person.LicenseNumbers.Add("#5452129");
        }

        private IList<Sale> GetPastSales()
        {
            IList<Sale> properties = new List<Sale>();

            Sale newProperty = new Sale
            {
                ID = 1,
                Property = new Property
                {
                    ID = 1,
                    NoBed = 7,
                    NoBath = 4,
                    Area = 6150,
                    AreaUnit = "sqft",
                    Price = 900000,

                    Location = new Location
                    {
                        DoorNo = "3247",
                        Street = "Greystone Dr",
                        City = "Jamul",
                        State = "CA",
                        Zip = "91935"
                    },
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Path="home5.jpg",
                            IsDefault=true
                        }
                    }
                },
                PurchasedDate = new DateTime(2017, 09, 12),
                RepresentedBy = "Seller"
            };
            properties.Add(newProperty);

            newProperty = new Sale
            {
                ID = 2,
                Property = new Property
                {
                    ID = 2,
                    NoBed = 6,
                    NoBath = (decimal)5.5,
                    Area = 5505,
                    AreaUnit = "sqft",
                    Price = 490000,

                    Location = new Location
                    {
                        DoorNo = "9951",
                        Street = "Watergum Trl",
                        City = "Santee",
                        State = "CA",
                        Zip = "92071"
                    },
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Path="home4.jpg",
                            IsDefault=true
                        }
                    }
                },
                PurchasedDate = new DateTime(2017, 07, 21),
                RepresentedBy = "Buyer"
            };
            properties.Add(newProperty);

            newProperty = new Sale
            {
                ID = 3,
                Property = new Property
                {
                    ID = 3,

                    NoBed = 6,
                    NoBath = (decimal)5.5,
                    Area = 5505,
                    AreaUnit = "sqft",

                    Location = new Location
                    {
                        DoorNo = "627",
                        Street = "Hawthorne Ave",
                        City = "El Cajon",
                        State = "CA",
                        Zip = "92020"
                    },
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Path="home12.jpg",
                            IsDefault=true
                        }
                    },
                    Price = 529000,
                },
                PurchasedDate = new DateTime(2017, 09, 11),
                RepresentedBy = "Buyer"
            };
            properties.Add(newProperty);

            newProperty = new Sale
            {
                ID = 4,
                Property = new Property
                {
                    ID = 4,
                    NoBed = 6,
                    NoBath = (decimal)5.5,
                    Area = 5505,
                    AreaUnit = "sqft",
                    Location = new Location
                    {
                        DoorNo = "9565",
                        Street = "Janfred Way",
                        City = "La Mesa",
                        State = "CA",
                        Zip = "91942"
                    },
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Path="home6.jpg",
                            IsDefault=true
                        }
                    },
                    Price = 555000,
                },
                PurchasedDate = new DateTime(2017, 07, 11),

                RepresentedBy = "Buyer"
            };
            properties.Add(newProperty);

            newProperty = new Sale
            {
                ID = 5,
                Property = new Property
                {
                    ID = 5,
                    NoBed = 6,
                    NoBath = (decimal)5.5,
                    Area = 5505,
                    AreaUnit = "sqft",
                    Location = new Location
                    {
                        DoorNo = "5160",
                        Street = "Alzeda Dr",
                        City = "La Mesa",
                        State = "CA",
                        Zip = "91941"
                    },
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Path="home7.jpg",
                            IsDefault=true
                        }
                    },
                    Price = 1265000,
                },
                PurchasedDate = new DateTime(2017, 07, 07),

                RepresentedBy = "Seller"
            };
            properties.Add(newProperty);

            return properties;
        }

        private IList<Review> GetReviews()
        {
            IList<Review> reviews = new List<Review>();
            Review review = new Review
            {
                ID = 1,
                LocalKnowledge = (decimal)4.5,
                Expertise = (decimal)4.2,
                Responsiveness = (decimal)5.0,
                NegotiationSkills = (decimal)4.1,
                Average = (decimal)4.5,
                ReviewdBy = "russroberts",
                Property = new Sale
                {
                    ID = 3,
                    Property = new Property
                    {
                        ID = 3,

                        NoBed = 6,
                        NoBath = (decimal)5.5,
                        Area = 5505,
                        AreaUnit = "sqft",

                        Location = new Location
                        {
                            DoorNo = "627",
                            Street = "Hawthorne Ave",
                            City = "El Cajon",
                            State = "CA",
                            Zip = "92020"
                        },
                        Price = 529000,
                    },
                    PurchasedDate = new DateTime(2017, 09, 11),
                    RepresentedBy = "Buyer"
                },
                Description = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients."
            };
            reviews.Add(review);

            review = new Review
            {
                ID = 1,
                LocalKnowledge = (decimal)4.5,
                Expertise = (decimal)4.2,
                Responsiveness = (decimal)5.0,
                NegotiationSkills = (decimal)4.1,
                Average = (decimal)4.5,
                ReviewdBy = "russroberts",
                Property = new Sale
                {
                    ID = 3,
                    Property = new Property
                    {
                        ID = 3,

                        NoBed = 6,
                        NoBath = (decimal)5.5,
                        Area = 5505,
                        AreaUnit = "sqft",

                        Location = new Location
                        {
                            DoorNo = "627",
                            Street = "Hawthorne Ave",
                            City = "El Cajon",
                            State = "CA",
                            Zip = "92020"
                        },
                        Price = 529000,
                    },
                    PurchasedDate = new DateTime(2017, 09, 11),
                    RepresentedBy = "Buyer"
                },
                Description = "Most important to me was communication and Mark saw that every question or concern of ours we met with full and complete information. In most cases, Mark delivered information to us before we even had to ask. I look forward to working with Mark in the future because I know that I can trust him to some more text some more text some more text."
            };
            reviews.Add(review);

            return reviews;
        }

        private IList<ListedProperty> GetActiveListing()
        {
            IList<ListedProperty> properties = new List<ListedProperty>();

            ListedProperty property = new ListedProperty
            {
                IsFavorited = false,
                Price = 345000,

                Location = new Location
                {
                    DoorNo = "472",
                    Street = "Pendorsa Dr",
                    City = "Alpine"
                },
                NoBed = 4,
                NoBath = 3,
                Area = 2785,
                AreaUnit = "sqft",
                Images = new List<Image>
                {
                    new Image
                    {
                        Path="home1.jpg",
                        IsDefault = true
                    },
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image()
                }
            };
            properties.Add(property);

            property = new ListedProperty
            {
                IsFavorited = true,
                Price = 345000,
                Location = new Location
                {
                    DoorNo = "472",
                    Street = "Pendorsa Dr",
                    City = "Alpine"
                },
                NoBed = 4,
                NoBath = 3,
                Area = 2785,
                AreaUnit = "sqft",
                Images = new List<Image>
                {
                    new Image
                    {
                        Path="home8.jpg",
                        IsDefault = true
                    },
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image()
                }
            };
            properties.Add(property);

            property = new ListedProperty
            {
                IsFavorited = false,
                Price = 345000,
                Location = new Location
                {
                    DoorNo = "472",
                    Street = "Pendorsa Dr",
                    City = "Alpine"
                },
                NoBed = 4,
                NoBath = 3,
                Area = 2785,
                AreaUnit = "sqft",
                Images = new List<Image>
                {
                    new Image
                    {
                        Path="home11.jpg",
                        IsDefault = true
                    },
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image(),
                    new Image()
                }
            };
            properties.Add(property);

            return properties;
        }

        private void PopulateAverageReview(Person person)
        {
        }
    }
}