﻿// <auto-generated />
using ApiZhou.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiZhou.Data.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20240419185744_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("LibraryZhou.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Continent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Winner")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            City = "Montevideo",
                            Continent = "South America",
                            Country = "Uruguay",
                            Gender = "Men",
                            Winner = "Uruguay",
                            Year = 1930
                        },
                        new
                        {
                            GameId = 2,
                            City = "Rome",
                            Continent = "Europe",
                            Country = "Italy",
                            Gender = "Men",
                            Winner = "Italy",
                            Year = 1934
                        },
                        new
                        {
                            GameId = 3,
                            City = "Paris",
                            Continent = "Europe",
                            Country = "France",
                            Gender = "Men",
                            Winner = "Italy",
                            Year = 1938
                        },
                        new
                        {
                            GameId = 4,
                            City = "Rio de Janeiro",
                            Continent = "South America",
                            Country = "Brazil",
                            Gender = "Men",
                            Winner = "Uruguay",
                            Year = 1950
                        },
                        new
                        {
                            GameId = 5,
                            City = "Bern",
                            Continent = "Europe",
                            Country = "Switzerland",
                            Gender = "Men",
                            Winner = "West Germany",
                            Year = 1954
                        },
                        new
                        {
                            GameId = 6,
                            City = "Stockholm",
                            Continent = "Europe",
                            Country = "Sweden",
                            Gender = "Men",
                            Winner = "Brazil",
                            Year = 1958
                        },
                        new
                        {
                            GameId = 7,
                            City = "Santiago",
                            Continent = "South America",
                            Country = "Chile",
                            Gender = "Men",
                            Winner = "Brazil",
                            Year = 1962
                        },
                        new
                        {
                            GameId = 8,
                            City = "London",
                            Continent = "Europe",
                            Country = "England",
                            Gender = "Men",
                            Winner = "England",
                            Year = 1966
                        },
                        new
                        {
                            GameId = 9,
                            City = "Mexico City",
                            Continent = "North America",
                            Country = "Mexico",
                            Gender = "Men",
                            Winner = "Brazil",
                            Year = 1970
                        },
                        new
                        {
                            GameId = 10,
                            City = "Munich",
                            Continent = "Europe",
                            Country = "West Germany",
                            Gender = "Men",
                            Winner = "West Germany",
                            Year = 1974
                        },
                        new
                        {
                            GameId = 11,
                            City = "Buenos Aires",
                            Continent = "South America",
                            Country = "Argentina",
                            Gender = "Men",
                            Winner = "Argentina",
                            Year = 1978
                        },
                        new
                        {
                            GameId = 12,
                            City = "Madrid",
                            Continent = "Europe",
                            Country = "Spain",
                            Gender = "Men",
                            Winner = "Italy",
                            Year = 1982
                        },
                        new
                        {
                            GameId = 13,
                            City = "Mexico City",
                            Continent = "North America",
                            Country = "Mexico",
                            Gender = "Men",
                            Winner = "Argentina",
                            Year = 1986
                        },
                        new
                        {
                            GameId = 14,
                            City = "Rome",
                            Continent = "Europe",
                            Country = "Italy",
                            Gender = "Men",
                            Winner = "West Germany",
                            Year = 1990
                        },
                        new
                        {
                            GameId = 15,
                            City = "Montevideo",
                            Continent = "South America",
                            Country = "Uruguay",
                            Gender = "Women",
                            Winner = "Uruguay",
                            Year = 1991
                        },
                        new
                        {
                            GameId = 16,
                            City = "Los Angeles",
                            Continent = "North America",
                            Country = "United States",
                            Gender = "Men",
                            Winner = "Brazil",
                            Year = 1994
                        },
                        new
                        {
                            GameId = 17,
                            City = "Rome",
                            Continent = "Europe",
                            Country = "Italy",
                            Gender = "Women",
                            Winner = "Norway",
                            Year = 1995
                        },
                        new
                        {
                            GameId = 18,
                            City = "Paris",
                            Continent = "Europe",
                            Country = "France",
                            Gender = "Men",
                            Winner = "France",
                            Year = 1998
                        },
                        new
                        {
                            GameId = 19,
                            City = "Pasadena/CA",
                            Continent = "North America",
                            Country = "United States",
                            Gender = "Women",
                            Winner = "United States",
                            Year = 1999
                        },
                        new
                        {
                            GameId = 20,
                            City = "Seoul and Tokyo",
                            Continent = "Asia",
                            Country = "South Korea and Japan",
                            Gender = "Men",
                            Winner = "Brazil",
                            Year = 2002
                        },
                        new
                        {
                            GameId = 21,
                            City = "Carson/CA",
                            Continent = "North America",
                            Country = "United States",
                            Gender = "Women",
                            Winner = "Germany",
                            Year = 2003
                        },
                        new
                        {
                            GameId = 22,
                            City = "Berlin",
                            Continent = "Europe",
                            Country = "Germany",
                            Gender = "Men",
                            Winner = "Italy",
                            Year = 2006
                        },
                        new
                        {
                            GameId = 23,
                            City = "Shanghai",
                            Continent = "Asia",
                            Country = "China",
                            Gender = "Women",
                            Winner = "Germany",
                            Year = 2007
                        },
                        new
                        {
                            GameId = 24,
                            City = "Johannesburg",
                            Continent = "Africa",
                            Country = "South Africa",
                            Gender = "Men",
                            Winner = "Spain",
                            Year = 2010
                        },
                        new
                        {
                            GameId = 25,
                            City = "Frankfurt",
                            Continent = "Europe",
                            Country = "Germany",
                            Gender = "Women",
                            Winner = "Japan",
                            Year = 2011
                        },
                        new
                        {
                            GameId = 26,
                            City = "Rio de Janeiro",
                            Continent = "South America",
                            Country = "Brazil",
                            Gender = "Men",
                            Winner = "Germany",
                            Year = 2014
                        },
                        new
                        {
                            GameId = 27,
                            City = "Vancouver",
                            Continent = "North America",
                            Country = "Canada",
                            Gender = "Women",
                            Winner = "United States",
                            Year = 2015
                        },
                        new
                        {
                            GameId = 28,
                            City = "Moscow",
                            Continent = "Europe",
                            Country = "Russia",
                            Gender = "Men",
                            Winner = "France",
                            Year = 2018
                        },
                        new
                        {
                            GameId = 29,
                            City = "Lyon",
                            Continent = "Europe",
                            Country = "France",
                            Gender = "Women",
                            Winner = "United States",
                            Year = 2019
                        },
                        new
                        {
                            GameId = 30,
                            City = "Doha",
                            Continent = "Asia",
                            Country = "Qatar",
                            Gender = "Men",
                            Winner = "Argentina",
                            Year = 2022
                        },
                        new
                        {
                            GameId = 31,
                            City = "Sydney",
                            Continent = "Oceania",
                            Country = "Australia",
                            Gender = "Women",
                            Winner = "Spain",
                            Year = 2023
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
