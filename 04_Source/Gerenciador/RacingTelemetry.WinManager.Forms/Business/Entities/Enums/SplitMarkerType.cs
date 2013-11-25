using System.ComponentModel;
namespace Business.Entities.Enums {
	public enum SplitMarkerType {
		[Description("Largada/Chegada")]
		StartFinish = 0,
		[Description("Speed Trap")]
		Speed = 1,
		[Description("Tempo parcial")]
		TimeSection = 2
	}
}
