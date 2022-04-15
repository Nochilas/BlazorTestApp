using Microsoft.AspNetCore.Components;

namespace BlazorTestApp.Client.Shared
{
    public class ExampleChildComponentBase : ComponentBase
    {
		protected static bool _darkThemeOn;

		protected static string Theme => _darkThemeOn ? "dark" : "light";

		public string ThemeDescription { get; set; }

		[Parameter]
		public RenderFragment ChildContent { get; set; }

		[Parameter]
		public string ParentStuff { get; set; }

		public void ChangeDescription()
		{
			_darkThemeOn = !_darkThemeOn;
			Console.WriteLine(ThemeDescription);
			ThemeDescription = $"The theme is {Theme}.";
			Console.WriteLine(ThemeDescription);
		}

		//Trying methods override
		protected override void OnInitialized()
		{
			_darkThemeOn = true;
			ThemeDescription = $"The theme is {Theme}.";
		}

		//protected override void OnParametersSet()
		//{
		//	//Code
		//}
	}
}
