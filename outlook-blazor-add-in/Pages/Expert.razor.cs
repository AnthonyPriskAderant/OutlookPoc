using BlazorAddIn.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorAddIn.Pages {
	public partial class Expert {
		[Inject]
		public IJSRuntime JSRuntime { get; set; } = default!;

		public IJSObjectReference JSModule { get; set; } = default!;

		public MailRead? MailReadData { get; set; }

		public void CallCollections() {
			Console.WriteLine($"Expert.razor.cs (CallCollections): Call Collections button was clicked.");
		}

	}
}
