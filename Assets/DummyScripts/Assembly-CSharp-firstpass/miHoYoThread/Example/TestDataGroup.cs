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
	public class TestDataGroup : IGroupNode // TypeDefIndex: 9092
	{
		// Fields
		private int _dataType; // 0x14
		private int _cnt; // 0x18
		private static IGroup _group; // 0x00
		private TestData[] _innerDatas; // 0x20
		private TestDataTask _task; // 0x28
	
		// Properties
		public int index { get; set; } // 0x0000000187642B40-0x0000000187642BA0 0x0000000187642D00-0x0000000187642D60
		public int dataType { /* [XID] */ /* 0x00000001897A3C90-0x00000001897A3CB0 */ get => default; } // 0x0000000187642AA0-0x0000000187642B40 
		public int dataCnt { /* [XID] */ /* 0x00000001897AB020-0x00000001897AB040 */ get => default; } // 0x0000000187642A00-0x0000000187642AA0 
		public TestData[] innerDatas { /* [XID] */ /* 0x00000001897C26A0-0x00000001897C26C0 */ get => default; } // 0x0000000187642BA0-0x0000000187642C40 
		public INode node { /* [XID] */ /* 0x00000001899B4470-0x00000001899B4490 */ get => default; } // 0x0000000187642C40-0x0000000187642D00 
	
		// Constructors
		public TestDataGroup() {} // 0x0000000187642990-0x0000000187642A00
		static TestDataGroup() {} // 0x0000000187642930-0x0000000187642990
	
		// Methods
		// [XID] // 0x00000001897B2E20-0x00000001897B2E40
		public static void Add(TestData data) {} // 0x0000000187642370-0x0000000187642480
		// [XID] // 0x00000001897BA9F0-0x00000001897BAA10
		public static void Remove(TestData data) {} // 0x0000000187642820-0x0000000187642930
		// [XID] // 0x00000001897D1500-0x00000001897D1520
		public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x0000000187642520-0x00000001876426C0
		// [XID] // 0x00000001897D93C0-0x00000001897D93E0
		public void AddData(TestData data) {} // 0x0000000187642290-0x0000000187642370
		// [XID] // 0x00000001897A9980-0x00000001897A99A0
		public void RemoveData(TestData data) {} // 0x00000001876426C0-0x0000000187642820
		// [XID] // 0x00000001897B11E0-0x00000001897B1200
		public void Destroy() {} // 0x0000000187642480-0x0000000187642520
	}
}
