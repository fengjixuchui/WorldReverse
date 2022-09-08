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
	public class SchedulerConsts // TypeDefIndex: 9046
	{
		// Fields
		private string[] SchedulerTypeEntryNames; // 0x10
		private string[] SchedulerTypeMainEntryNames; // 0x18
		private string[] SchedulerTypeWaitNames; // 0x20
		private string[] SchedulerTypeFlushNames; // 0x28
		private int[] SchedulerPrioritys; // 0x30
	
		// Constructors
		public SchedulerConsts() {} // 0x0000000187634320-0x0000000187634FF0
	
		// Methods
		// [XID] // 0x000000018964F5B0-0x000000018964F5D0
		public virtual string SchedulerTypeEntryName(int schedulerType) => default; // 0x0000000187633FA0-0x0000000187634080
		// [XID] // 0x000000018975D040-0x000000018975D060
		public virtual string SchedulerTypeMainEntryName(int schedulerType) => default; // 0x0000000187634160-0x0000000187634240
		// [XID] // 0x0000000189A9A940-0x0000000189A9A960
		public virtual string SchedulerTypeWaitName(int schedulerType) => default; // 0x0000000187634240-0x0000000187634320
		// [XID] // 0x0000000189AA19B0-0x0000000189AA19D0
		public virtual string SchedulerTypeFlushName(int schedulerType) => default; // 0x0000000187634080-0x0000000187634160
		// [XID] // 0x0000000189AA8F90-0x0000000189AA8FB0
		public virtual int SchedulerPriority(int schedulerType) => default; // 0x0000000187633ED0-0x0000000187633FA0
	}
}
