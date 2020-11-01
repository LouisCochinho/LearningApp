using Microsoft.AspNetCore.Components;

namespace LearningApp.Components
{
	public partial class Counter : ComponentBase
	{
		public int CurrentCount { get; set; }

		public void IncrementCount()
		{
			CurrentCount++;
		}
	}
}
