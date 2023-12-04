using NUnit.Framework;

namespace MyLibrary
{
	public class MyArea
	{
		public float FindCircleArea(float R)
		{
			return (float)3.14 * R * R;
		}

		public float FideTriangeArea(float Side1, float Side2, float Side3)
		{
			float HalfPerimetr = (Side1 + Side2 + Side3) / 2;
			float MyFormula = HalfPerimetr * (HalfPerimetr - Side1) * (HalfPerimetr - Side2) * (HalfPerimetr - Side3);
			return (float)Math.Sqrt(MyFormula);
		}

		public bool IsTriangleStraight(float A, float B, float C)
		{
			bool result;
			result = (Math.Pow(A, 2) + Math.Pow(B, 2)) == Math.Pow(C, 2);
			return result;

			/*Выражение:
			return (Math.Pow(A,2) + Math.Pow(B,2) == Math.Pow(C,2));
			Мне не кажется удобным
			*/
		}

		[TestFixture]
		public class MyAreaTests
		{
			MyArea TestingClass = new MyArea();

			[Test]
			public void FindCircleArea_Test()
			{
				float radius = 5.0f;
				float expectedArea = 78.5f;
				float actualArea = TestingClass.FindCircleArea(radius);
				Assert.AreEqual(expectedArea, actualArea, 0.01f);
			}

			[Test]
			public void FideTriangeArea_Test()
			{
				float side1 = 3.0f;
				float side2 = 4.0f;
				float side3 = 5.0f;
				float expectedArea = 6.0f;
				float actualArea = TestingClass.FideTriangeArea(side1, side2, side3);
				Assert.AreEqual(expectedArea, actualArea, 0.01f);
			}

			[Test]
			public void IsTriangleStraight_Test()
			{
				float sideA = 3.0f;
				float sideB = 4.0f;
				float sideC = 5.0f;
				bool expectedIsRightAngle = true;
				bool actualIsRightAngle = TestingClass.IsTriangleStraight(sideA, sideB, sideC);
				Assert.IsTrue(actualIsRightAngle);
			}
		}

	}
}