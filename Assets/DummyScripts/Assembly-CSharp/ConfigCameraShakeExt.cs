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
public class ConfigCameraShakeExt : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17797
{
	// Fields
	private bool _infinity; // 0x10
	private bool _baseOnCamera; // 0x11
	private bool _afterShake; // 0x12
	private SimpleSafeFloat baseCycleRawNum; // 0x14
	private SimpleSafeFloat cycleDampingRawNum; // 0x18
	private SimpleSafeFloat rangeAttenuationRawNum; // 0x1C

	// Properties
	public bool infinity { /* [XID] */ /* 0x00000001899DF8A0-0x00000001899DF8C0 */ get => default; /* [XID] */ /* 0x0000000189896040-0x0000000189896060 */ private set {} } // 0x0000000183959DB0-0x0000000183959E50 0x000000018395A420-0x000000018395A4D0
	public bool baseOnCamera { /* [XID] */ /* 0x00000001899E73B0-0x00000001899E73D0 */ get => default; /* [XID] */ /* 0x00000001898A5040-0x00000001898A5060 */ private set {} } // 0x0000000183959630-0x00000001839596D0 0x000000018395A370-0x000000018395A420
	public bool afterShake { /* [XID] */ /* 0x00000001898AC480-0x00000001898AC4A0 */ get => default; /* [XID] */ /* 0x00000001898B3A60-0x00000001898B3A80 */ private set {} } // 0x000000018395AE10-0x000000018395AEB0 0x0000000183959C20-0x0000000183959CD0
	public float baseCycle { /* [XID] */ /* 0x00000001898BB850-0x00000001898BB870 */ get => default; /* [XID] */ /* 0x00000001898C2B00-0x00000001898C2B20 */ private set {} } // 0x000000018395A290-0x000000018395A370 0x0000000183959B40-0x0000000183959C20
	public float cycleDamping { /* [XID] */ /* 0x00000001898CA480-0x00000001898CA4A0 */ get => default; /* [XID] */ /* 0x00000001898D1D30-0x00000001898D1D50 */ private set {} } // 0x000000018395A930-0x000000018395AA10 0x000000018395A4D0-0x000000018395A5B0
	public float rangeAttenuation { /* [XID] */ /* 0x00000001898D95B0-0x00000001898D95D0 */ get => default; /* [XID] */ /* 0x00000001898E12A0-0x00000001898E12C0 */ private set {} } // 0x0000000183959CD0-0x0000000183959DB0 0x000000018395B310-0x000000018395B3F0

	// Constructors
	public ConfigCameraShakeExt() {} // 0x000000018395B750-0x000000018395B820

	// Methods
	// [XID] // 0x0000000189847720-0x0000000189847740
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018395B3F0-0x000000018395B570
	// [XID] // 0x00000001898F03C0-0x00000001898F03E0
	public void InitEmpty() {} // 0x000000018395AA10-0x000000018395AB10
	[BlackList] // 0x00000001898F7DF0-0x00000001898F7E30
	// [XID] // 0x00000001898F7DF0-0x00000001898F7E30
	public bool FromJson(JSONNode node) => default; // 0x000000018395A5B0-0x000000018395A930
	// [XID] // 0x0000000189902620-0x0000000189902640
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183958FF0-0x0000000183959630
	// [XID] // 0x0000000189909BE0-0x0000000189909C00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C73 */, bool useObjectPool = false /* Metadata: 0x00AF7C77 */) => default; // 0x000000018395AB10-0x000000018395AE10
	// [XID] // 0x00000001899113E0-0x0000000189911400
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C78 */, bool useObjectPool = false /* Metadata: 0x00AF7C7C */) => default; // 0x0000000183959E50-0x000000018395A290
	[BlackList] // 0x0000000189918FA0-0x0000000189918FE0
	// [XID] // 0x0000000189918FA0-0x0000000189918FE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839596D0-0x00000001839599A0
	// [XID] // 0x0000000189923800-0x0000000189923820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018395AEB0-0x000000018395B310
	[BlackList] // 0x000000018992AEC0-0x000000018992AF00
	// [XID] // 0x000000018992AEC0-0x000000018992AF00
	public virtual void AutoAllocTypeFields() {} // 0x00000001839599A0-0x0000000183959A40
	[BlackList] // 0x0000000189935250-0x0000000189935290
	// [XID] // 0x0000000189935250-0x0000000189935290
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183959A40-0x0000000183959B40
	[BlackList] // 0x000000018993FC00-0x000000018993FC40
	// [XID] // 0x000000018993FC00-0x000000018993FC40
	public virtual void ReturnToObjectPool() {} // 0x000000018395B6B0-0x000000018395B750
	[BlackList] // 0x000000018994A100-0x000000018994A140
	// [XID] // 0x000000018994A100-0x000000018994A140
	public virtual void OnPoolAllocated() {} // 0x000000018395B610-0x000000018395B6B0
	[BlackList] // 0x00000001899547A0-0x00000001899547E0
	// [XID] // 0x00000001899547A0-0x00000001899547E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018395B570-0x000000018395B610
}

