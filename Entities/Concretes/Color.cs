using System;
using Entities.Abstracts;

namespace Entities.Concretes
{
	public class Color:IEntity
	{
		public int ColorId { get; set; }
		public string ColorName { get; set; }
	}
}