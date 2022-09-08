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

public class AbilitySystemGroupNode : IGroupNode // TypeDefIndex: 26563
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private AbilitySystemData[] _innerDatas; // 0x28
	private AbilitySystemTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x0000000189609C90-0x0000000189609CD0 */ get; set; } // 0x0000000182571410-0x0000000182571470 0x0000000182571530-0x0000000182571590
	public int dataType { /* [XID] */ /* 0x000000018961BAA0-0x000000018961BAC0 */ get => default; } // 0x0000000182571370-0x0000000182571410 
	public int dataCnt { /* [XID] */ /* 0x00000001896230C0-0x00000001896230E0 */ get => default; } // 0x00000001825712D0-0x0000000182571370 
	public AbilitySystemData[] innerDatas { /* [XID] */ /* 0x000000018964FFE0-0x0000000189650000 */ get => default; } // 0x0000000182571130-0x00000001825711D0 
	public INode node { /* [XID] */ /* 0x00000001896578E0-0x0000000189657900 */ get => default; } // 0x0000000182571470-0x0000000182571530 

	// Constructors
	public AbilitySystemGroupNode() {} // 0x0000000182571230-0x00000001825712D0
	static AbilitySystemGroupNode() {} // 0x00000001825711D0-0x0000000182571230

	// Methods
	// [XID] // 0x000000018962A8B0-0x000000018962A8D0
	private int GetFreeIndex() => default; // 0x0000000182570A70-0x0000000182570BB0
	// [XID] // 0x0000000189631FF0-0x0000000189632010
	private int GetFreeIndexOnly() => default; // 0x0000000182570FD0-0x0000000182571130
	// [XID] // 0x0000000189639B10-0x0000000189639B30
	private void AddFreeIndex(int index) {} // 0x0000000182570F00-0x0000000182570FD0
	// [XID] // 0x0000000189641000-0x0000000189641020
	public static AbilitySystemData GetAndAdd() => default; // 0x0000000182570D50-0x0000000182570F00
	// [XID] // 0x00000001896488D0-0x00000001896488F0
	public static void Remove(AbilitySystemData data) {} // 0x0000000182570760-0x00000001825708C0
	// [XID] // 0x000000018965EF60-0x000000018965EF80
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x00000001825708C0-0x0000000182570A70
	// [XID] // 0x0000000189666720-0x0000000189666740
	private void InitDataPool(int maxNum) {} // 0x0000000182570370-0x00000001825704D0
	// [XID] // 0x000000018966DE60-0x000000018966DE80
	public AbilitySystemData GetData() => default; // 0x0000000182570250-0x0000000182570370
	// [XID] // 0x0000000189675CC0-0x0000000189675CE0
	public void AddData(AbilitySystemData data) {} // 0x0000000182570BB0-0x0000000182570D50
	// [XID] // 0x000000018967D550-0x000000018967D570
	public void RemoveData(AbilitySystemData data) {} // 0x00000001825705D0-0x0000000182570760
	// [XID] // 0x0000000189684BE0-0x0000000189684C00
	public void Destroy() {} // 0x00000001825704D0-0x00000001825705D0
}

