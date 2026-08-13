using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BTCPayServer.Hosting;

public static class MvcOptionsExtensions
{
	public static void RouteValuesTakePrecedenceOverForm(this MvcOptions options)
	{
		RouteValueProviderFactory routeProvider = options.ValueProviderFactories.OfType<RouteValueProviderFactory>().Single();
		options.ValueProviderFactories.Remove(routeProvider);
		options.ValueProviderFactories.Insert(0, routeProvider);
	}
}
