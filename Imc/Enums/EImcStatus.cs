using System.ComponentModel;

namespace Imc.Enums;

public enum EImcStatus
{
	[Description("Abaixo do peso")]
	Underweight,

	[Description("Peso ideal")]
	IdealWeight,

	[Description("Pouco acima do peso")]
	SlightlyOverweight,

	[Description("Acima do peso")]
	Overweight,

	[Description("Obesidade")]
	Obesity
}
