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
public class ConfigCombatBeHit : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17690
{
	// Fields
	private string _hitBloodEffect; // 0x10
	private bool _hitAutoRedirect; // 0x18
	private bool _muteAllHit; // 0x19
	private bool _muteAllHitEffect; // 0x1A
	private bool _muteAllHitText; // 0x1B
	private bool _ignoreMinHitVY; // 0x1C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBeHitBlendShake _blendShake; // 0x20

	// Properties
	public string hitBloodEffect { /* [XID] */ /* 0x0000000189749740-0x0000000189749760 */ get => default; /* [XID] */ /* 0x0000000189750C00-0x0000000189750C20 */ private set {} } // 0x00000001832B10F0-0x00000001832B1190 0x00000001832AFEA0-0x00000001832AFF50
	public bool hitAutoRedirect { /* [XID] */ /* 0x0000000189757FF0-0x0000000189758010 */ get => default; /* [XID] */ /* 0x000000018975FB70-0x000000018975FB90 */ private set {} } // 0x00000001832AFE00-0x00000001832AFEA0 0x00000001832AFD50-0x00000001832AFE00
	public bool muteAllHit { /* [XID] */ /* 0x0000000189703BE0-0x0000000189703C00 */ get => default; /* [XID] */ /* 0x000000018976E640-0x000000018976E660 */ private set {} } // 0x00000001832B09D0-0x00000001832B0A70 0x00000001832AFF50-0x00000001832B0000
	public bool muteAllHitEffect { /* [XID] */ /* 0x000000018970B430-0x000000018970B450 */ get => default; /* [XID] */ /* 0x000000018977D720-0x000000018977D740 */ private set {} } // 0x00000001832B1970-0x00000001832B1A10 0x00000001832B0000-0x00000001832B00B0
	public bool muteAllHitText { /* [XID] */ /* 0x0000000189785000-0x0000000189785020 */ get => default; /* [XID] */ /* 0x000000018978C4B0-0x000000018978C4D0 */ private set {} } // 0x00000001832B0930-0x00000001832B09D0 0x00000001832B0BC0-0x00000001832B0C70
	public bool ignoreMinHitVY { /* [XID] */ /* 0x00000001897939A0-0x00000001897939C0 */ get => default; /* [XID] */ /* 0x000000018979BC90-0x000000018979BCB0 */ private set {} } // 0x00000001832B0B20-0x00000001832B0BC0 0x00000001832B0A70-0x00000001832B0B20
	public ConfigBeHitBlendShake blendShake { /* [XID] */ /* 0x00000001897217C0-0x00000001897217E0 */ get => default; /* [XID] */ /* 0x00000001897AA780-0x00000001897AA7A0 */ private set {} } // 0x00000001832B0D50-0x00000001832B0DF0 0x00000001832B1A10-0x00000001832B1AC0

	// Constructors
	public ConfigCombatBeHit() {} // 0x00000001832B1B60-0x00000001832B1BD0

	// Methods
	// [XID] // 0x00000001896ED690-0x00000001896ED6B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832B1690-0x00000001832B1830
	// [XID] // 0x00000001897B9C50-0x00000001897B9C70
	public void InitEmpty() {} // 0x00000001832B0C70-0x00000001832B0D50
	[BlackList] // 0x00000001897C1D70-0x00000001897C1DB0
	// [XID] // 0x00000001897C1D70-0x00000001897C1DB0
	public bool FromJson(JSONNode node) => default; // 0x00000001832B05B0-0x00000001832B0930
	// [XID] // 0x00000001897CC2F0-0x00000001897CC310
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832AF250-0x00000001832AF8A0
	// [XID] // 0x00000001897D3BE0-0x00000001897D3C00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77DF */, bool useObjectPool = false /* Metadata: 0x00AF77E3 */) => default; // 0x00000001832B0DF0-0x00000001832B10F0
	// [XID] // 0x00000001897DB5B0-0x00000001897DB5D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77E4 */, bool useObjectPool = false /* Metadata: 0x00AF77E8 */) => default; // 0x00000001832B00B0-0x00000001832B05B0
	[BlackList] // 0x00000001897E2D00-0x00000001897E2D40
	// [XID] // 0x00000001897E2D00-0x00000001897E2D40
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832AF8A0-0x00000001832AFB70
	// [XID] // 0x00000001897ED730-0x00000001897ED750
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832B1190-0x00000001832B1690
	[BlackList] // 0x00000001897F4F90-0x00000001897F4FD0
	// [XID] // 0x00000001897F4F90-0x00000001897F4FD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001832AFB70-0x00000001832AFC10
	[BlackList] // 0x00000001897FF7B0-0x00000001897FF7F0
	// [XID] // 0x00000001897FF7B0-0x00000001897FF7F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832AFC10-0x00000001832AFD50
	[BlackList] // 0x0000000189809D10-0x0000000189809D50
	// [XID] // 0x0000000189809D10-0x0000000189809D50
	public virtual void ReturnToObjectPool() {} // 0x00000001832B1AC0-0x00000001832B1B60
	[BlackList] // 0x0000000189814210-0x0000000189814250
	// [XID] // 0x0000000189814210-0x0000000189814250
	public virtual void OnPoolAllocated() {} // 0x00000001832B18D0-0x00000001832B1970
	[BlackList] // 0x000000018981EDE0-0x000000018981EE20
	// [XID] // 0x000000018981EDE0-0x000000018981EE20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832B1830-0x00000001832B18D0
}

