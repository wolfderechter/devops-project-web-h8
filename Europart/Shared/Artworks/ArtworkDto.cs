﻿using EuropArt.Domain.Artists;
using EuropArt.Shared.Artists;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;

namespace EuropArt.Shared.Artworks
{
    public class ArtworkDto
    {
        public class Index
        {
            public int Id { get; set; }
            public int ArtistId { get; set; }
            public ArtistName ArtistName { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; }
            public DateTime DateCreated { get; set; }
            
        }

        public class Detail : Index
        {
            public string Description { get; set; }
        }

        public class Create
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public DateTime DateCreated { get; set; }
            public string Style { get; set; }
            public string Category { get; set; }

            //public IEnumerable<string> ImagePaths { get; set; }
            public string ImagePath { get; set; }
            //public ArtistDto.Detail Artist { get; set; }
            public class ArtworkValidator : AbstractValidator<Create>
            {
                public ArtworkValidator(IStringLocalizer<Resources.Artworks.Validation> Loc)
                {
                    RuleFor(p => p.Name).NotEmpty().WithMessage(Loc["Title"]);
                    RuleFor(p => p.Name).MaximumLength(100).WithMessage(Loc["BuyNow"]);
                    RuleFor(p => p.Price).NotEmpty().WithMessage(Loc["Price"]);
                    RuleFor(p => p.Price).GreaterThan(0).WithMessage(Loc["Negative"]);
                }
            }


        }

        public class Edit
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }

            public string ImagePath { get; set; }

            public class ArtworkValidator : AbstractValidator<Edit>
            {
                public ArtworkValidator(IStringLocalizer<Resources.Artworks.Validation> Loc)
                {
                    RuleFor(p => p.Name).MaximumLength(100).WithMessage(Loc["BuyNow"]);
                    RuleFor(p => p.Name).NotEmpty().WithMessage(Loc["Title"]);
                    RuleFor(p => p.Price).GreaterThan(0).WithMessage(Loc["Negative"]);
                    RuleFor(p => p.Price).NotEmpty().WithMessage(Loc["Price"]);
                }
            }
        }
    }
}
