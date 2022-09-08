/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class SchedulerTask : ISchedulerTask // TypeDefIndex: 9049
	{
		// Fields
		private static int _curId; // 0x00
		protected int _id; // 0x10
		protected SchedulerType _type; // 0x14
		protected SchedulerTaskType _taskType; // 0x18
	
		// Properties
		public static int nextId { /* [XID] */ /* 0x0000000189B827E0-0x0000000189B82800 */ get => default; } // 0x0000000187639520-0x00000001876395F0 
		public int id { /* [XID] */ /* 0x0000000189BA5DE0-0x0000000189BA5E00 */ get => default; } // 0x0000000187639480-0x0000000187639520 
		public SchedulerType type { /* [XID] */ /* 0x0000000189BAD140-0x0000000189BAD160 */ get => default; } // 0x0000000187639690-0x0000000187639730 
		public SchedulerTaskType taskType { /* [XID] */ /* 0x0000000189BB4980-0x0000000189BB49A0 */ get => default; } // 0x00000001876395F0-0x0000000187639690 
	
		// Constructors
		public SchedulerTask() {} // 0x0000000187639420-0x0000000187639480
		static SchedulerTask() {} // 0x00000001876393C0-0x0000000187639420
	
		// Methods
		public static STaskType Create<STaskType>(SchedulerType pType, SchedulerTaskType pTaskType)
			where STaskType : SchedulerTask, new() => default;
		// [IDTag] // 0x0000000189B89E50-0x0000000189B89E90
		// [XID] // 0x0000000189B89E50-0x0000000189B89E90
		public static void Spawn(ISchedulerTask task) {} // 0x0000000187639180-0x0000000187639250
		// [IDTag] // 0x0000000189B94190-0x0000000189B941D0
		// [XID] // 0x0000000189B94190-0x0000000189B941D0
		public static void UnSpawn(ISchedulerTask task) {} // 0x0000000187639250-0x0000000187639320
		// [XID] // 0x0000000189B9E390-0x0000000189B9E3B0
		public int CompareTo(ISchedulerTask task) => default; // 0x0000000187638DD0-0x0000000187638EB0
		// [XID] // 0x00000001899C43C0-0x00000001899C43E0
		public void Init(int pId, SchedulerType pType, SchedulerTaskType pTaskType) {} // 0x0000000187639000-0x00000001876390E0
		// [XID] // 0x00000001899D3110-0x00000001899D3130
		public virtual void Execute(float deltaTime) {} // 0x0000000187638F50-0x0000000187639000
		// [IDTag] // 0x0000000189BCB4C0-0x0000000189BCB500
		// [XID] // 0x0000000189BCB4C0-0x0000000189BCB500
		public void Spawn() {} // 0x00000001876390E0-0x0000000187639180
		// [IDTag] // 0x0000000189BD57A0-0x0000000189BD57E0
		// [XID] // 0x0000000189BD57A0-0x0000000189BD57E0
		public void UnSpawn() {} // 0x0000000187639320-0x00000001876393C0
		// [XID] // 0x00000001899F0C70-0x00000001899F0C90
		public void Destroy() {} // 0x0000000187638EB0-0x0000000187638F50
	}
}
