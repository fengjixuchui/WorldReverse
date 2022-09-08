/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class CycleStatTickModuleNode : IStatLogNode // TypeDefIndex: 27859
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CycleStat _cycleStat; // 0x10
		private HashSet<object> instances; // 0x18
		private bool bDisableReturnCycleStat; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<CycleStatTickModuleNode> children; // 0x28
		public static double currentFrameMainThreadGamplayTime; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int callAsNumber; // 0x30
		private string percentStr; // 0x38
	
		// Properties
		public CycleStat cycleStat { /* [XID] */ /* 0x00000001899048A0-0x00000001899048C0 */ get => default; } // 0x0000000184D7CF50-0x0000000184D7CFF0 
		public int calls { /* [XID] */ /* 0x000000018990C090-0x000000018990C0B0 */ get => default; } // 0x0000000184D7CE80-0x0000000184D7CF50 
		public string statName { /* [XID] */ /* 0x00000001898A1750-0x00000001898A1770 */ get => default; } // 0x0000000184D7D210-0x0000000184D7D2C0 
		public string percent { /* [XID] */ /* 0x00000001898A8F80-0x00000001898A8FA0 */ get => default; } // 0x0000000184D7D170-0x0000000184D7D210 
		public double totalTime { /* [XID] */ /* 0x00000001898B08F0-0x00000001898B0910 */ get => default; } // 0x0000000184D7D430-0x0000000184D7D4F0 
		public double tickTime { /* [XID] */ /* 0x00000001898B7F50-0x00000001898B7F70 */ get => default; } // 0x0000000184D7D370-0x0000000184D7D430 
		public double fixedTickTime { /* [XID] */ /* 0x00000001898BF680-0x00000001898BF6A0 */ get => default; } // 0x0000000184D7CFF0-0x0000000184D7D0B0 
		public double lateTickTime { /* [XID] */ /* 0x00000001898C6F00-0x00000001898C6F20 */ get => default; } // 0x0000000184D7D0B0-0x0000000184D7D170 
		public int statOwnerType { /* [XID] */ /* 0x00000001898CE420-0x00000001898CE440 */ get => default; } // 0x0000000184D7D2C0-0x0000000184D7D370 
	
		// Constructors
		public CycleStatTickModuleNode() {} // 0x0000000184D7CDC0-0x0000000184D7CE80
		static CycleStatTickModuleNode() {} // 0x0000000184D7CD60-0x0000000184D7CDC0
	
		// Methods
		// [XID] // 0x0000000189849350-0x0000000189849370
		public object Clone() => default; // 0x0000000184D7C570-0x0000000184D7C830
		// [XID] // 0x0000000189850AF0-0x0000000189850B10
		public void RefreshPercentageStrWithGameplayTime(double inGameplayTime) {} // 0x0000000184D7C1A0-0x0000000184D7C2D0
		// [XID] // 0x0000000189857EE0-0x0000000189857F00
		public void RefreshPercentageStrWithGameplayTimeRecursively(double inGameplayTime) {} // 0x0000000184D7BFF0-0x0000000184D7C1A0
		// [XID] // 0x000000018985F030-0x000000018985F050
		public void AddChild(CycleStatTickModuleNode inChild) {} // 0x0000000184D7CA10-0x0000000184D7CAE0
		// [XID] // 0x00000001899AB8D0-0x00000001899AB8F0
		public static CycleStatTickModuleNode CreateNode(string inStatID, int inStatOwnerType) => default; // 0x0000000184D7BEE0-0x0000000184D7BFF0
		// [XID] // 0x00000001899C92E0-0x00000001899C9300
		public static CycleStatTickModuleNode CreateNodeWithCycleStatCleanDuplicated(CycleStat inStat) => default; // 0x0000000184D7C920-0x0000000184D7CA10
		// [XID] // 0x0000000189875530-0x0000000189875550
		public static CycleStatTickModuleNode CreateNodeWithCycleStatRef(CycleStat inStat) => default; // 0x0000000184D7C2D0-0x0000000184D7C3A0
		// [XID] // 0x000000018987D0A0-0x000000018987D0C0
		public void Flush() {} // 0x0000000184D7C3A0-0x0000000184D7C570
		// [XID] // 0x0000000189884040-0x0000000189884060
		private void ConditionalAddInstance(object inInstance) {} // 0x0000000184D7C830-0x0000000184D7C920
		// [XID] // 0x000000018988B760-0x000000018988B780
		public void AccumulateCycleStatAll(CycleStat inStat) {} // 0x0000000184D7CAE0-0x0000000184D7CC00
		// [XID] // 0x00000001898048F0-0x0000000189804910
		public void AccumulateCycleStat(CycleStat inStat, EntityManager.TickType inType) {} // 0x0000000184D7CC00-0x0000000184D7CD60
	}
}
