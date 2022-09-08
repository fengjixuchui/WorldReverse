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
public class QuestContentEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18809
{
	// Fields
	private QuestContentType _type; // 0x10
	private int[] _param; // 0x18
	private uint _count; // 0x20

	// Properties
	public QuestContentType type { /* [XID] */ /* 0x00000001899FF960-0x00000001899FF980 */ get => default; /* [XID] */ /* 0x0000000189A071D0-0x0000000189A071F0 */ private set {} } // 0x0000000181C24ED0-0x0000000181C24F70 0x0000000181C248D0-0x0000000181C24980
	public int[] param { /* [XID] */ /* 0x0000000189A0E6F0-0x0000000189A0E710 */ get => default; /* [XID] */ /* 0x0000000189A15DE0-0x0000000189A15E00 */ private set {} } // 0x0000000181C25020-0x0000000181C250C0 0x0000000181C24F70-0x0000000181C25020
	public uint count { /* [XID] */ /* 0x0000000189A1D320-0x0000000189A1D340 */ get => default; /* [XID] */ /* 0x0000000189A247F0-0x0000000189A24810 */ private set {} } // 0x0000000181C24830-0x0000000181C248D0 0x0000000181C243B0-0x0000000181C24460

	// Constructors
	public QuestContentEx() {} // 0x0000000181C25160-0x0000000181C251C0

	// Methods
	// [XID] // 0x0000000189A2BD30-0x0000000189A2BD50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C24C70-0x0000000181C24D90
	// [XID] // 0x0000000189A33400-0x0000000189A33420
	public void InitEmpty() {} // 0x0000000181C24460-0x0000000181C24530
	[BlackList] // 0x0000000189A3AC80-0x0000000189A3ACC0
	// [XID] // 0x0000000189A3AC80-0x0000000189A3ACC0
	public bool FromJson(JSONNode node) => default; // 0x0000000181C24030-0x0000000181C243B0
	// [XID] // 0x0000000189A45580-0x0000000189A455A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C23590-0x0000000181C23910
	// [XID] // 0x00000001899CDC30-0x00000001899CDC50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD6B */, bool useObjectPool = false /* Metadata: 0x00AFAD6F */) => default; // 0x0000000181C24530-0x0000000181C24830
	// [XID] // 0x0000000189A543D0-0x0000000189A543F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD70 */, bool useObjectPool = false /* Metadata: 0x00AFAD74 */) => default; // 0x0000000181C23D30-0x0000000181C24030
	[BlackList] // 0x0000000189A5BEC0-0x0000000189A5BF00
	// [XID] // 0x0000000189A5BEC0-0x0000000189A5BF00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C23910-0x0000000181C23BE0
	// [XID] // 0x0000000189A66720-0x0000000189A66740
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C24980-0x0000000181C24C70
	[BlackList] // 0x0000000189A6DF00-0x0000000189A6DF40
	// [XID] // 0x0000000189A6DF00-0x0000000189A6DF40
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C23BE0-0x0000000181C23C80
	[BlackList] // 0x0000000189A78940-0x0000000189A78980
	// [XID] // 0x0000000189A78940-0x0000000189A78980
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C23C80-0x0000000181C23D30
	[BlackList] // 0x0000000189A83140-0x0000000189A83180
	// [XID] // 0x0000000189A83140-0x0000000189A83180
	public virtual void ReturnToObjectPool() {} // 0x0000000181C250C0-0x0000000181C25160
	[BlackList] // 0x0000000189A8D9F0-0x0000000189A8DA30
	// [XID] // 0x0000000189A8D9F0-0x0000000189A8DA30
	public virtual void OnPoolAllocated() {} // 0x0000000181C24E30-0x0000000181C24ED0
	[BlackList] // 0x0000000189A982C0-0x0000000189A98300
	// [XID] // 0x0000000189A982C0-0x0000000189A98300
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C24D90-0x0000000181C24E30
}

