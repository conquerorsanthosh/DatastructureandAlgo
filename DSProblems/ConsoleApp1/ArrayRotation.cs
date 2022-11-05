using System;

namespace DSProblems
{
	public static class ArrayRotation
	{

		public static void  PostiveandNegativeRotation(int[] source, int length, int nRotations)
		{
			/* 
			source={4,5,3,45,8,9,10} 
			4 rotations   
			P1= (0,1,2) ,
			P2=Length-K-1 (3-6 , 3,4,5,6)   7-1-4=2
			P1=3,5,4 (Reverse of P1)
			P2=10,9,8,45
			P1P2=3,5,4,10,9,8,45
			Reverse of P1P2= 45,8,9,10,4,5,3
			whis is Equivalent of 4 rotations of source array
			
			 for negative rotations

			-4 rotations
			4%7=-4

			nrotations= -4+length=-4+7=3 ( 3 positive rotations)
			P1=0 to  7-3-1=3 
			P2=
			 
			 
			 
			 
			 
			 
			 */

			nRotations = nRotations % length;
			if (nRotations < 0) 
			{
				nRotations = length + nRotations;
			}
			Reverse(source, 0, length - nRotations - 1);
			Reverse(source, nRotations - 1, length - 1);
			Reverse(source, 0, length - 1);

			Console.WriteLine("After" + nRotations + "array looks like this");

			foreach(int k in source) 
			{
				Console.Write(k);
			}

		}

		private static void  Reverse(int[] source, int start, int end)
		{
			int temp = -1;
			int i = start;
			int j = end;
			while (i < j)
			{
				temp = source[i];
				source[i] = source[j];
				source[j] = temp;
				i++; j--;
	
			}

		}
	}
}
