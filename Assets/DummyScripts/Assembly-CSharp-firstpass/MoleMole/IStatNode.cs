/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public interface IStatNode : IEnumerable<MoleMole.IStatNode>, IReusable // TypeDefIndex: 10094
	{
		// Properties
		string statID { get; }
		float inclusiveTotal { get; }
		float exclusiveTotal { get; }
	
		// Methods
		void ClearStat();
		void AccumulateStat(float inValue);
		float CollectStat();
		void AddChild(IStatNode inNode);
		string ToString(int toStringType, int depth, Action<string, int> onHandleStatString);
		void OnRecycle();
	}
}
