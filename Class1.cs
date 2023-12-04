namespace MyLibrary
{
	public class MyArea
	{
		float FindCircleArea(float R)
		{
			return (float)3.14 * R * R;
		}

		float FideTriangeArea(float Side1, float Side2, float Side3)
		{
			float HalfPerimetr = (Side1 + Side2 + Side3) / 2;
			float MyFormula = HalfPerimetr * (HalfPerimetr - Side1) * (HalfPerimetr - Side2) * (HalfPerimetr - Side3);
			return 0;
		}


		bool IsTriangleStraight(float A, float B, float C)
		{
			bool result;
			result = (Math.Pow(A,2) + Math.Pow(B,2)) == Math.Pow(C,2);
			return result;

			/*Выражение:
			return (Math.Pow(A,2) + Math.Pow(B,2) == Math.Pow(C,2));
			Мне не кажется удобным
			*/
		}



	}

}