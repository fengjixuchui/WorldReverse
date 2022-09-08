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
public class ConfigCombatSpeech : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17697
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _headShotSpeechEvent; // 0x10

	// Properties
	public ConfigWwiseString headShotSpeechEvent { /* [XID] */ /* 0x0000000189803F70-0x0000000189803F90 */ get => default; /* [XID] */ /* 0x000000018980B360-0x000000018980B380 */ private set {} } // 0x00000001839C1B40-0x00000001839C1BE0 0x00000001839C1DA0-0x00000001839C1E50

	// Constructors
	public ConfigCombatSpeech() {} // 0x00000001839C2C90-0x00000001839C2CF0

	// Methods
	// [XID] // 0x0000000189812A80-0x0000000189812AA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839C29D0-0x00000001839C2AB0
	// [XID] // 0x000000018981A620-0x000000018981A640
	public void InitEmpty() {} // 0x00000001839C2420-0x00000001839C24F0
	[BlackList] // 0x0000000189821DD0-0x0000000189821E10
	// [XID] // 0x0000000189821DD0-0x0000000189821E10
	public bool FromJson(JSONNode node) => default; // 0x00000001839C20A0-0x00000001839C2420
	// [XID] // 0x000000018982C4F0-0x000000018982C510
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839C1670-0x00000001839C1870
	// [XID] // 0x00000001898339E0-0x0000000189833A00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7825 */, bool useObjectPool = false /* Metadata: 0x00AF7829 */) => default; // 0x00000001839C24F0-0x00000001839C27F0
	// [XID] // 0x000000018983AF60-0x000000018983AF80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF782A */, bool useObjectPool = false /* Metadata: 0x00AF782E */) => default; // 0x00000001839C1E50-0x00000001839C20A0
	[BlackList] // 0x0000000189842700-0x0000000189842740
	// [XID] // 0x0000000189842700-0x0000000189842740
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839C1870-0x00000001839C1B40
	// [XID] // 0x000000018984CA80-0x000000018984CAA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839C27F0-0x00000001839C29D0
	[BlackList] // 0x0000000189853B40-0x0000000189853B80
	// [XID] // 0x0000000189853B40-0x0000000189853B80
	public virtual void AutoAllocTypeFields() {} // 0x00000001839C1BE0-0x00000001839C1C80
	[BlackList] // 0x000000018985DD50-0x000000018985DD90
	// [XID] // 0x000000018985DD50-0x000000018985DD90
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839C1C80-0x00000001839C1DA0
	[BlackList] // 0x0000000189868870-0x00000001898688B0
	// [XID] // 0x0000000189868870-0x00000001898688B0
	public virtual void ReturnToObjectPool() {} // 0x00000001839C2BF0-0x00000001839C2C90
	[BlackList] // 0x0000000189872BB0-0x0000000189872BF0
	// [XID] // 0x0000000189872BB0-0x0000000189872BF0
	public virtual void OnPoolAllocated() {} // 0x00000001839C2B50-0x00000001839C2BF0
	[BlackList] // 0x000000018987D840-0x000000018987D880
	// [XID] // 0x000000018987D840-0x000000018987D880
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839C2AB0-0x00000001839C2B50
}

