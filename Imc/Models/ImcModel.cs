using Imc.Enums;

namespace Imc.Models;

public class ImcModel
{
	public double Weight { get; private set; }
	public double Height { get; private set; }
	public ESex Sex { get; private set; }
    public bool IsElderly { get; private set; }
	public double Imc { get; private set; }
	public EImcStatus Status { get; private set; }
	public ImcMessage Message { get; private set; } = null!;

	public ImcModel(double weight, double height, ESex sex, bool isElderly)
	{
		Weight = weight;
		Height = height;
		Sex = sex;
		IsElderly = isElderly;
		Imc = (weight / (height * height));
		CalculateStatus();
	}

	private void CalculateStatus()
	{
		if (IsElderly)
		{
			CalculateElderlyStatus();
			return;
		}

		if (Sex is ESex.Masculino)
		{
			CalculateMaleStatus();
			return;
		}

		CalculateFemaleStatus();
	}

	private void CalculateElderlyStatus()
	{
		if(Imc < 22)
		{
			Status = EImcStatus.Underweight;
			Message = ImcMessageBuilder.Build(Status);
		} else if (Imc < 27)
		{
			Status = EImcStatus.IdealWeight;
			Message = ImcMessageBuilder.Build(Status);
		} else
		{
			Status = EImcStatus.Overweight;
			Message = ImcMessageBuilder.Build(Status);
		}
	}

	private void CalculateMaleStatus()
	{
		if (Imc < 20.7)
		{
			Status = EImcStatus.Underweight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else if (Imc < 26.4)
		{
			Status = EImcStatus.IdealWeight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else if (Imc < 27.8)
		{
			Status = EImcStatus.SlightlyOverweight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else if (Imc < 31.1)
		{
			Status = EImcStatus.Overweight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else
		{
			Status = EImcStatus.Obesity;
			Message = ImcMessageBuilder.Build(Status);
		}
	}

	private void CalculateFemaleStatus()
	{
		if (Imc < 19.1)
		{
			Status = EImcStatus.Underweight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else if (Imc < 25.8)
		{
			Status = EImcStatus.IdealWeight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else if (Imc < 27.3)
		{
			Status = EImcStatus.SlightlyOverweight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else if (Imc < 32.3)
		{
			Status = EImcStatus.Overweight;
			Message = ImcMessageBuilder.Build(Status);
		}
		else
		{
			Status = EImcStatus.Obesity;
			Message = ImcMessageBuilder.Build(Status);
		}
	}
}
