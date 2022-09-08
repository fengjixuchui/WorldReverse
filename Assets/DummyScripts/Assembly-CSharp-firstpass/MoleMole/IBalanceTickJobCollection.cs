/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public interface IBalanceTickJobCollection // TypeDefIndex: 10472
	{
		// Methods
		void AddTickableObject(BalanceTickObjectProxy inObject, double inGlobalTime);
		void RemoveTickableObject(BalanceTickObjectProxy inObject, double inGlobalTime);
		void RefreshRequestTickInterval(float inGlobalTime, float deltaTime, Action<BalanceTickObjectProxy, int> onRequestIntervalChange);
		void Validate(Action<BalanceTickObjectProxy> onValidate);
	}
}
