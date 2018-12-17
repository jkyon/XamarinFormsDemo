using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quotes
{
    using Data;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditQuotePage : ContentPage
    {
        private readonly bool isEdit;
        private Quote currentQuote;

		public EditQuotePage (Quote quote, bool isEdit = false)
		{
			InitializeComponent ();

		    this.isEdit = isEdit;
		    this.currentQuote = quote;
		    BindingContext = quote;
		   
		}

	    private async void Save(object sender, EventArgs e)
	    {
	        var edited = BindingContext as Quote;
	        if (this.isEdit)
	        {
	            this.currentQuote.Author = edited.Author;
	            this.currentQuote.QuoteText = edited.QuoteText;
	        }
	        else
	        {
	            QuoteManager.Instance.Quotes.Add(edited);
	        }

	        await Navigation.PopAsync();
	    }
	}
}