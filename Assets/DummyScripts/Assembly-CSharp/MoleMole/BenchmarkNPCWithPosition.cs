/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using Newtonsoft.Json;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class BenchmarkNPCWithPosition : IBatchedBenchmarkJob, IComparableBenchmarkJob // TypeDefIndex: 27676
	{
		// Fields
		public uint defaultNPCID; // 0x10
		public int defaultTickLOD; // 0x14
		public PositionNPC[] npcs; // 0x18
		public int frameCount; // 0x20
		private int _currentIdx; // 0x24
	
		// Properties
		public string statFolderName { /* [XID] */ /* 0x0000000189B398F0-0x0000000189B39910 */ get => default; } // 0x0000000181AD56A0-0x0000000181AD5750 
		public string statFileType { /* [XID] */ /* 0x0000000189B41290-0x0000000189B412B0 */ get => default; } // 0x0000000181AD55F0-0x0000000181AD56A0 
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public string statFileName { /* [XID] */ /* 0x0000000189B48B20-0x0000000189B48B40 */ get => default; } // 0x0000000181AD5540-0x0000000181AD55F0 
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public int statLOD { /* [XID] */ /* 0x0000000189B50310-0x0000000189B50330 */ get => default; } // 0x0000000181AD5750-0x0000000181AD57F0 
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public StatUnitMMA benchmarkFrameData { /* [XID] */ /* 0x0000000189B756D0-0x0000000189B75710 */ get; /* [XID] */ /* 0x0000000189B7FCB0-0x0000000189B7FCF0 */ private set; } // 0x0000000181AD54E0-0x0000000181AD5540 0x0000000181AD5850-0x0000000181AD58B0
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public StatUnitMMA baseFrameData { get; /* [XID] */ /* 0x0000000189B91A40-0x0000000189B91A80 */ private set; } // 0x0000000181AD5480-0x0000000181AD54E0 0x0000000181AD57F0-0x0000000181AD5850
	
		// Nested types
		[Serializable]
		public class PositionNPC // TypeDefIndex: 27677
		{
			// Fields
			public SerializableVector3 pos; // 0x10
			public SerializableVector3 rot; // 0x1C
			public uint npcID; // 0x28
			public int tickLOD; // 0x2C
	
			// Constructors
			public PositionNPC() {} // 0x0000000181AEC2A0-0x0000000181AEC350
		}
	
		// Constructors
		public BenchmarkNPCWithPosition() {} // 0x0000000181AD5410-0x0000000181AD5480
	
		// Methods
		// [XID] // 0x0000000189B57AC0-0x0000000189B57AE0
		public int GetJobCount() => default; // 0x0000000181AD3F90-0x0000000181AD4030
		// [XID] // 0x0000000189B5F490-0x0000000189B5F4B0
		public void PreStat() {} // 0x0000000181AD3C60-0x0000000181AD3D00
		// [XID] // 0x0000000189B66B40-0x0000000189B66B60
		public string ToCSVTitleString() => default; // 0x0000000181AD3910-0x0000000181AD3BA0
		// [XID] // 0x0000000189B6E000-0x0000000189B6E020
		public string ToInvalidStatCSVString() => default; // 0x0000000181AD4280-0x0000000181AD4880
		// [XID] // 0x0000000189B9BE10-0x0000000189B9BE30
		public string ToValidStatCSVString(StatUnitMMA BaseFrameData) => default; // 0x0000000181AD4880-0x0000000181AD5410
		[DebuggerHidden] // 0x0000000189BA3550-0x0000000189BA3590
		// [XID] // 0x0000000189BA3550-0x0000000189BA3590
		public IEnumerator ExecuteAt(int index) => default; // 0x0000000181AD4030-0x0000000181AD4140
		// [XID] // 0x0000000189BAD6C0-0x0000000189BAD6E0
		public void PostStat() {} // 0x0000000181AD3BA0-0x0000000181AD3C60
		// [XID] // 0x0000000189BB4E30-0x0000000189BB4E50
		public object GenerateSampleJob() => default; // 0x0000000181AD3D00-0x0000000181AD3F90
		// [XID] // 0x0000000189BBC3E0-0x0000000189BBC400
		public static void TestJsonFile() {} // 0x0000000181AD4140-0x0000000181AD4280
	}
}
