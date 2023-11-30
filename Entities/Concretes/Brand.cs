using System;
using Entities.Abstracts;

namespace Entities.Concretes
{
	public class Brand:IEntity
	{
		public int BrandId { get; set; }
		public string BrandName { get; set; }
	}
}