/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public static class LuaTaskUtils // TypeDefIndex: 21166
	{
		// Fields
		private static Dictionary<int, ISimplePool> _poolDic; // 0x00
	
		// Constructors
		static LuaTaskUtils() {} // 0x0000000184F15BE0-0x0000000184F15C70
	
		// Methods
		private static LuaTask GetTask<TaskType>(LuaTaskType type)
			where TaskType : LuaTask, new() => default;
		public static void ReleaseTask<TaskType>(TaskType task)
			where TaskType : LuaTask, new() {}
		// [XID] // 0x0000000189A66330-0x0000000189A66350
		public static LuaTask CreateTask(int taskQueueID, LuaTaskType type, BaseActor actor, string tag) => default; // 0x0000000184F15890-0x0000000184F15BE0
		public static T CreateTask<T>(int taskQueueID, LuaTaskType type, BaseActor actor, string tag)
			where T : LuaTask, new() => default;
		// [XID] // 0x0000000189A6DA80-0x0000000189A6DAA0
		public static void Clear() {} // 0x0000000184F15650-0x0000000184F15890
	}
}
