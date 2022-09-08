/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TerrainGrassGroupNode : IGroupNode // TypeDefIndex: 26648
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private TerrainGrassData[] _innerDatas; // 0x28
	private TerrainGrassTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x0000000189B05C30-0x0000000189B05C70 */ get; set; } // 0x0000000181096480-0x00000001810964E0 0x00000001810965A0-0x0000000181096600
	public int dataType { /* [XID] */ /* 0x0000000189B176C0-0x0000000189B176E0 */ get => default; } // 0x00000001810963E0-0x0000000181096480 
	public int dataCnt { /* [XID] */ /* 0x0000000189B1EF50-0x0000000189B1EF70 */ get => default; } // 0x0000000181096340-0x00000001810963E0 
	public TerrainGrassData[] innerDatas { /* [XID] */ /* 0x0000000189B4BBB0-0x0000000189B4BBD0 */ get => default; } // 0x00000001810961A0-0x0000000181096240 
	public INode node { /* [XID] */ /* 0x0000000189B53170-0x0000000189B53190 */ get => default; } // 0x00000001810964E0-0x00000001810965A0 

	// Constructors
	public TerrainGrassGroupNode() {} // 0x00000001810962A0-0x0000000181096340
	static TerrainGrassGroupNode() {} // 0x0000000181096240-0x00000001810962A0

	// Methods
	// [XID] // 0x0000000189B26910-0x0000000189B26930
	private int GetFreeIndex() => default; // 0x0000000181095B10-0x0000000181095C50
	// [XID] // 0x0000000189B2DAA0-0x0000000189B2DAC0
	private int GetFreeIndexOnly() => default; // 0x0000000181096040-0x00000001810961A0
	// [XID] // 0x0000000189B34EA0-0x0000000189B34EC0
	private void AddFreeIndex(int index) {} // 0x0000000181095F70-0x0000000181096040
	// [XID] // 0x0000000189B3C770-0x0000000189B3C790
	public static TerrainGrassData GetAndAdd() => default; // 0x0000000181095DC0-0x0000000181095F70
	// [XID] // 0x0000000189B444D0-0x0000000189B444F0
	public static void Remove(TerrainGrassData data) {} // 0x0000000181095820-0x0000000181095980
	// [XID] // 0x0000000189B5AB00-0x0000000189B5AB20
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x0000000181095980-0x0000000181095B10
	// [XID] // 0x0000000189B61ED0-0x0000000189B61EF0
	private void InitDataPool(int maxNum, bool needPool) {} // 0x0000000181095440-0x00000001810955C0
	// [XID] // 0x0000000189B69B80-0x0000000189B69BA0
	public TerrainGrassData GetData() => default; // 0x0000000181095320-0x0000000181095440
	// [XID] // 0x0000000189B71120-0x0000000189B71140
	public void AddData(TerrainGrassData data) {} // 0x0000000181095C50-0x0000000181095DC0
	// [XID] // 0x0000000189B78730-0x0000000189B78750
	public void RemoveData(TerrainGrassData data) {} // 0x00000001810956C0-0x0000000181095820
	// [XID] // 0x0000000189B7FCF0-0x0000000189B7FD10
	public void Destroy() {} // 0x00000001810955C0-0x00000001810956C0
}

