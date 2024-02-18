using Imc.Enums;
using System.ComponentModel.DataAnnotations;

namespace Imc.ViewModels;

public class ImcViewModel
{
	[Required]
	[Range(
		0, 
		double.MaxValue, 
		MinimumIsExclusive = true, 
		ConvertValueInInvariantCulture = true
	)]
	public double? Weight { get; set; } = default!;

	[Required]
	[Range(
		0,
		double.MaxValue,
		MinimumIsExclusive = true,
		ConvertValueInInvariantCulture = true
	)]
	public double? Height { get; set; } = default!;
	
	[Required]
	public ESex? Sex { get; set; } = default!;
	
	[Required]
	public bool IsElderly { get; set; } = default!;
}
