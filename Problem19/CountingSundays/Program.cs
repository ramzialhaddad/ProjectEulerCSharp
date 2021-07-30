using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 19 Counting Sundays:
 *	- 1 Jan 1990 was a Monday
 *	- Thirty days is September, April, June and November.
 *	- All the rest are 31 days
 *	- Except Febuary, unless leap year which is 29 days
 *	- Leap year occurs on any year evenly dividlbe by 4 but not on a century unless it is divisible by 400
 *	
 *	How many sundays fell on the first of the month during 1 Jan 1901 to 31 Dec 2000
 */

namespace CountingSundays
{
	class Program
	{
		enum Days
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
		static void Main(string[] args)
		{
		}
	}
}
