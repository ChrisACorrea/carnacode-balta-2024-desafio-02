using Imc.Enums;

namespace Imc.Models;

public static class ImcMessageBuilder
{
	public static ImcMessage Build(EImcStatus status) => status switch
	{
		EImcStatus.Underweight => new()
		{
			Title = "Abaixo do peso",
			Description = "Cuidado você está abaixo do peso, dê uma atenção para sua saúde."
		},
		EImcStatus.IdealWeight => new()
		{
			Title = "Peso Ideal",
			Description = "Parabéns! Você está no peso ideal, continue mantendo este estilo!"
		},
		EImcStatus.SlightlyOverweight => new()
		{
			Title = "Um pouco acima do peso",
			Description = "Você está pouco acima do peso ideal. Comece a ficar de olho na saúde."
		},
		EImcStatus.Overweight => new()
		{
			Title = "Sobrepeso",
			Description = "Cuidado! Você está com sobrepeso, dê uma atenção para sua saúde"
		},
		EImcStatus.Obesity => new()
		{
			Title = "Obesidade",
			Description = "Cuidado! Você está obeso, procure auxílio médico urgente!."
		},
		_ => throw new NotImplementedException()
	};

}
