using System;
using BepInEx;
using UnityEngine;

namespace CrazyThursday
{
	[BepInPlugin("com.crazy.thursday", "CrazyThursdayException", "1.0.0")]
	public class CrazyThursdayPlugin : BaseUnityPlugin
	{
		private void Update()
		{
			if (DateTime.Now.DayOfWeek != DayOfWeek.Thursday) return;
			throw new CrazyThursdayException();
		}
	}

	public class CrazyThursdayException : Exception
	{
		public CrazyThursdayException() : base("V我50") { }
		public CrazyThursdayException(string message) : base(message) { }
	}
}
