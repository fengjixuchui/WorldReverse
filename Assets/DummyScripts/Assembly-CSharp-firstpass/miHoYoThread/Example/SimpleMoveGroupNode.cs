/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using miHoYoThread;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread.Example
{
	public class SimpleMoveGroupNode : IGroupNode // TypeDefIndex: 9084
	{
		// Fields
		private int _dataType; // 0x14
		private int _cnt; // 0x18
		private static IGroup _group; // 0x00
		private SimpleMoveData[] _innerDatas; // 0x20
		private SimpleMoveTask _task; // 0x28
	
		// Properties
		public int index { get; set; } // 0x000000018726CDD0-0x000000018726CE30 0x000000018726CF90-0x000000018726CFF0
		public int dataType { /* [XID] */ /* 0x00000001897B1CD0-0x00000001897B1CF0 */ get => default; } // 0x000000018726CD30-0x000000018726CDD0 
		public int dataCnt { /* [XID] */ /* 0x00000001895E8AB0-0x00000001895E8AD0 */ get => default; } // 0x000000018726CC90-0x000000018726CD30 
		public SimpleMoveData[] innerDatas { /* [XID] */ /* 0x0000000189696DB0-0x0000000189696DD0 */ get => default; } // 0x000000018726CE30-0x000000018726CED0 
		public INode node { /* [XID] */ /* 0x000000018969E2E0-0x000000018969E300 */ get => default; } // 0x000000018726CED0-0x000000018726CF90 
	
		// Constructors
		public SimpleMoveGroupNode() {} // 0x000000018726CC20-0x000000018726CC90
		static SimpleMoveGroupNode() {} // 0x000000018726CBC0-0x000000018726CC20
	
		// Methods
		// [XID] // 0x000000018985F310-0x000000018985F330
		public static void Add(SimpleMoveData data) {} // 0x000000018726C460-0x000000018726C5C0
		// [XID] // 0x000000018968F2E0-0x000000018968F300
		public static void Remove(SimpleMoveData data) {} // 0x000000018726CA60-0x000000018726CBC0
		// [XID] // 0x00000001896A5360-0x00000001896A5380
		public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x000000018726C660-0x000000018726C800
		// [XID] // 0x0000000189A00D30-0x0000000189A00D50
		public void AddData(SimpleMoveData data) {} // 0x000000018726C340-0x000000018726C460
		// [XID] // 0x000000018977C560-0x000000018977C580
		public void RemoveData(SimpleMoveData data) {} // 0x000000018726C800-0x000000018726CA60
		// [XID] // 0x00000001899674B0-0x00000001899674D0
		public void Destroy() {} // 0x000000018726C5C0-0x000000018726C660
	}
}
