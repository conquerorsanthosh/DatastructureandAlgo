using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static  class StringCompress
	{
		public static  int Compress(char[] chars)
		{
			int reptitionCount = 1;
			int current = 0, traverse = 0, replace = 0;
			
			while (current < chars.Length)
			{
				traverse = current + 1;
				reptitionCount = 1;
				while (traverse <= chars.Length - 1)
				{
					if (chars[traverse] == chars[traverse - 1])
					{
						traverse++;
						reptitionCount++;
					}
					else
					{
						break;
					}
				}

				if (reptitionCount > 1)
				{
					//placing the character value
					chars[replace++] = chars[current];

					//placing the count value
					string countStr=reptitionCount.ToString();
					for(int i = 0; i < countStr.Length; i++) 
					{
						chars[replace++]=countStr[i];

					}
					current = traverse;
				}
				else
				{
					chars[replace] = chars[current];
					replace++;
					current = traverse;
				}

			}
			return replace;
		}
	}
}
