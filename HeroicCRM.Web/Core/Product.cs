using System;

namespace HeroicCRM.Web.Core
{
	public class Product
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreateDate { get; set; }

		public Customer Customer { get; set; }

		public Product()
		{
			CreateDate = DateTime.Today;
		}
	}
}