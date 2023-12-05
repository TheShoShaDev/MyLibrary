using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

/*Создан на случай неверно понятого задания*/

namespace MyLibrary
{
	public interface Shape
	{
		float FindArea();
	}

	public class Triangle : Shape
	{
		float Side1;
		float Side2;
		float Side3;

		Triangle(float Side1, float Side2, float Side3)
		{
			this.Side1 = Side1;
			this.Side2 = Side2;
			this.Side3 = Side3;
		}

		Triangle()
		{

		}

		public float FindArea()
		{
			float HalfPerimetr = (Side1 + Side2 + Side3) / 2;
			float MyFormula = HalfPerimetr * (HalfPerimetr - Side1) * (HalfPerimetr - Side2) * (HalfPerimetr - Side3);
			return (float)Math.Sqrt(MyFormula);
		}

		public float FindArea(float Side1, float Side2, float Side3)
		{
			float HalfPerimetr = (Side1 + Side2 + Side3) / 2;
			float MyFormula = HalfPerimetr * (HalfPerimetr - Side1) * (HalfPerimetr - Side2) * (HalfPerimetr - Side3);
			return (float)Math.Sqrt(MyFormula);
		}

		public bool IsTriangleStraight()
		{
			bool result;
			result = (Math.Pow(Side1, 2) + Math.Pow(Side2, 2)) == Math.Pow(Side3, 2);
			return result;

			/*Выражение:
			return (Math.Pow(Side1,2) + Math.Pow(Side2,2) == Math.Pow(Side3,2));
			Мне не кажется удобным
			*/
		}

		public bool IsTriangleStraight(float Side1, float Side2, float Side3)
		{
			bool result;
			result = (Math.Pow(Side1, 2) + Math.Pow(Side2, 2)) == Math.Pow(Side3, 2);
			return result;

		}
	}

	public class Circle : Shape
	{
		float Pi = 3.14f;
		float Radius;

		Circle(float Radius)
		{
			this.Radius = Radius;
		}

		Circle()
		{

		}

		public float FindArea()
		{
			return Pi * Radius * Radius;
		}

		public float FindArea(float Radius)
		{
			return Pi * Radius * Radius;
		}
	}

	public class Rectagle : Shape
	{
		float Side1;
		float Side2;

		Rectagle(float Side1 , float Side2)
		{
			this.Side1 = Side1;
			this.Side2 = Side2;
		}

		Rectagle()
		{

		}

		public float FindArea()
		{
			return Side1 * Side2;
		}

		public float FindArea(float Side1, float Side2)
		{
			return Side1 * Side2;
		}
	}
}
