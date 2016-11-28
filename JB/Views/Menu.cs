using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace JB
{
	public class Menu : ContentPage
	{
		public Menu()
		{
			Content = new StackLayout
			{
				
				VerticalOptions = LayoutOptions.Center,
				Children = {
						
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Jakub Bednář"
						},
						new Button
						{
							Text = "O mě",
							Command = showPageCommand(new o_me())
						},
						new Button
						{
							Text = "Projekty",
							Command = showPageCommand(new projekty())
						},
						new Button
						{
							Text = "Kontakt",
							Command = showPageCommand(new kontakt())
						}


					}
			};

		}
		Command showPageCommand(Page page)
		{
			return new Command((() =>
			{
				Navigation.PushAsync(page);
			}));


		}
	}
}
