/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public enum SchedulerType // TypeDefIndex: 9042
	{
		INVALID = -1,
		UPDATE = 0,
		LATE_PRE_UPDATE = 1,
		LATE_POST_UPDATE = 2,
		AFTER_RES_TO_UPDATE_END = 3,
		LATE_POST_UPDATE_TO_NEXT_BEFORE_LATE_UPDATE = 4,
		RENDER_TO_NEXT_BEFORE_RES = 5,
		RENDER_TO_NEXT_BEFORE_LATE_UPDATE = 6,
		RENDER_TO_NEXT_BEFORE_NETWORK = 7,
		AFTER_NETWORK_TO_RENDER = 8,
		COUNT = 9
	}
}
