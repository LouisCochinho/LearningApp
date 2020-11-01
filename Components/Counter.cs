using Microsoft.AspNetCore.Components;

namespace TodoList.Components
{
	public partial class Counter: ComponentBase
	{
		public int CurrentCount { get; set; }

		public void IncrementCount()
		{
			CurrentCount++;
		}
	}
}
