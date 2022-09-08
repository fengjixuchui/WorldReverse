/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FocusAssistanceGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16355
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private FocusAssistance _ps4; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private FocusAssistance _ps5; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private FocusAssistance _other; // 0x20

	// Properties
	public FocusAssistance ps4 { /* [XID] */ /* 0x0000000189765A50-0x0000000189765A70 */ get => default; /* [XID] */ /* 0x000000018976D240-0x000000018976D260 */ private set {} } // 0x0000000181F52200-0x0000000181F522A0 0x0000000181F522A0-0x0000000181F52350
	public FocusAssistance ps5 { /* [XID] */ /* 0x0000000189774690-0x00000001897746B0 */ get => default; /* [XID] */ /* 0x000000018977C0E0-0x000000018977C100 */ private set {} } // 0x0000000181F52160-0x0000000181F52200 0x0000000181F528F0-0x0000000181F529A0
	public FocusAssistance other { /* [XID] */ /* 0x0000000189783A70-0x0000000189783A90 */ get => default; /* [XID] */ /* 0x000000018978B280-0x000000018978B2A0 */ private set {} } // 0x0000000181F51CC0-0x0000000181F51D60 0x0000000181F529A0-0x0000000181F52A50

	// Constructors
	public FocusAssistanceGroup() {} // 0x0000000181F52AF0-0x0000000181F52B50

	// Methods
	// [XID] // 0x0000000189792760-0x0000000189792780
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F52680-0x0000000181F527B0
	// [XID] // 0x0000000189799CB0-0x0000000189799CD0
	public void InitEmpty() {} // 0x0000000181F51D60-0x0000000181F51E60
	[BlackList] // 0x00000001897A1B20-0x00000001897A1B60
	// [XID] // 0x00000001897A1B20-0x00000001897A1B60
	public bool FromJson(JSONNode node) => default; // 0x0000000181F51940-0x0000000181F51CC0
	// [XID] // 0x00000001897AC300-0x00000001897AC320
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181F50BD0-0x0000000181F50FC0
	// [XID] // 0x00000001897B42D0-0x00000001897B42F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38DE */, bool useObjectPool = false /* Metadata: 0x00AF38E2 */) => default; // 0x0000000181F51E60-0x0000000181F52160
	// [XID] // 0x00000001897BBF50-0x00000001897BBF70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38E3 */, bool useObjectPool = false /* Metadata: 0x00AF38E7 */) => default; // 0x0000000181F51550-0x0000000181F51940
	[BlackList] // 0x00000001897C3710-0x00000001897C3750
	// [XID] // 0x00000001897C3710-0x00000001897C3750
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F50FC0-0x0000000181F51290
	// [XID] // 0x00000001897CE020-0x00000001897CE040
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F52350-0x0000000181F52680
	[BlackList] // 0x00000001897D5590-0x00000001897D55D0
	// [XID] // 0x00000001897D5590-0x00000001897D55D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181F51290-0x0000000181F51330
	[BlackList] // 0x00000001897DFE90-0x00000001897DFED0
	// [XID] // 0x00000001897DFE90-0x00000001897DFED0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181F51330-0x0000000181F51550
	[BlackList] // 0x00000001897EA740-0x00000001897EA780
	// [XID] // 0x00000001897EA740-0x00000001897EA780
	public virtual void ReturnToObjectPool() {} // 0x0000000181F52A50-0x0000000181F52AF0
	[BlackList] // 0x00000001897F51B0-0x00000001897F51F0
	// [XID] // 0x00000001897F51B0-0x00000001897F51F0
	public virtual void OnPoolAllocated() {} // 0x0000000181F52850-0x0000000181F528F0
	[BlackList] // 0x00000001897FFAF0-0x00000001897FFB30
	// [XID] // 0x00000001897FFAF0-0x00000001897FFB30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181F527B0-0x0000000181F52850
}

