﻿using FluentValidation;
using Hamburger_Application.Areas.Admin.Models;

namespace Hamburger_Application.Validations.Dessert
{
    public class UpdateDessertVMValidator:AbstractValidator<DessertUpdateVM>
    {
        public UpdateDessertVMValidator()
        {
			RuleFor(f => f.Name).NotEmpty().WithMessage("Dessert name must not be empty");
			RuleFor(f => f.Name).MaximumLength(30).WithMessage("Dessert name maximum characters must be 30");
			RuleFor(f => f.Price).NotEmpty().WithMessage("Price cannot be a empty");
			RuleFor(f => f.Price).GreaterThan(0).WithMessage("Price cannot be a negative value");
			RuleFor(f => f.Piece).GreaterThan(0).WithMessage("Piece cannot be a negative value");
			RuleFor(f => f.imgCover).Must(BeValidImageFormat).WithMessage("Invalid photo format. Only JPEG, JPG and PNG formats are allowed.");
		}
		private bool BeValidImageFormat(IFormFile photo)
		{
			if (photo is null)                 // photo null => true;
				return true;



			var validFormats = new[] { ".jpg", ".jpeg", ".png" };
			var fileExtension = Path.GetExtension(photo.FileName);    //return jpg, jpeg, png



			return validFormats.Contains(fileExtension.ToLower());
		}
	}
}
