/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class MemoryTCA // TypeDefIndex: 27852
	{
		// Fields
		public string statName; // 0x10
		public float total; // 0x18
		public int count; // 0x1C
	
		// Properties
		public float average { /* [XID] */ /* 0x0000000189762400-0x0000000189762420 */ get => default; } // 0x0000000184F1CA80-0x0000000184F1CB40 
	
		// Constructors
		public MemoryTCA() {} // Dummy constructor
		public MemoryTCA(string inStatName, float inTotal, int inCount = 1 /* Metadata: 0x00B0D071 */) {} // 0x0000000184F1C9D0-0x0000000184F1CA80
		public MemoryTCA(MemoryTCA otherTCA) {} // 0x0000000184F1C930-0x0000000184F1C9D0
	
		// Methods
		// [XID] // 0x0000000189769A60-0x0000000189769A80
		protected void Init(string inStatName, float inTotal, int inCount = 1 /* Metadata: 0x00B0D075 */) {} // 0x0000000184F1C850-0x0000000184F1C930
		// [IDTag] // 0x0000000189771050-0x0000000189771090
		// [XID] // 0x0000000189771050-0x0000000189771090
		public void Merge(float inTotal, int inCount) {} // 0x0000000184F1C780-0x0000000184F1C850
		// [IDTag] // 0x000000018977B5C0-0x000000018977B600
		// [XID] // 0x000000018977B5C0-0x000000018977B600
		public void Merge(MemoryTCA otherTCA) {} // 0x0000000184F1C620-0x0000000184F1C780
		// [XID] // 0x0000000189785F10-0x0000000189785F30
		public string ToLog() => default; // 0x0000000184F1C380-0x0000000184F1C620
	}
}
