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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigPaimon : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18791
{
	// Fields
	private MoleMole.Config.Vector _followOffSet; // 0x10
	private SimpleSafeFloat slowDownRangeXZRawNum; // 0x1C
	private SimpleSafeFloat slowDownRangeYRawNum; // 0x20
	private SimpleSafeFloat showRandomCDMinRawNum; // 0x24
	private SimpleSafeFloat showRandomCDMaxRawNum; // 0x28

	// Properties
	public MoleMole.Config.Vector followOffSet { /* [XID] */ /* 0x0000000189907760-0x0000000189907780 */ get => default; /* [XID] */ /* 0x00000001898F0260-0x00000001898F0280 */ private set {} } // 0x00000001855408F0-0x00000001855409D0 0x0000000185542460-0x0000000185542530
	public float slowDownRangeXZ { /* [XID] */ /* 0x00000001897FE640-0x00000001897FE660 */ get => default; /* [XID] */ /* 0x00000001898FF2F0-0x00000001898FF310 */ private set {} } // 0x0000000185541FE0-0x00000001855420C0 0x0000000185540B90-0x0000000185540C70
	public float slowDownRangeY { /* [XID] */ /* 0x0000000189805D90-0x0000000189805DB0 */ get => default; /* [XID] */ /* 0x000000018990E5B0-0x000000018990E5D0 */ private set {} } // 0x00000001855420C0-0x00000001855421A0 0x0000000185541AC0-0x0000000185541BA0
	public float showRandomCDMin { /* [XID] */ /* 0x000000018979C630-0x000000018979C650 */ get => default; /* [XID] */ /* 0x000000018991D630-0x000000018991D650 */ private set {} } // 0x00000001855414B0-0x0000000185541590 0x0000000185540C70-0x0000000185540D50
	public float showRandomCDMax { /* [XID] */ /* 0x00000001897A3B70-0x00000001897A3B90 */ get => default; /* [XID] */ /* 0x000000018992C420-0x000000018992C440 */ private set {} } // 0x0000000185542530-0x0000000185542610 0x00000001855416E0-0x00000001855417C0

	// Constructors
	public ConfigPaimon() {} // 0x00000001855426B0-0x0000000185542790

	// Methods
	// [XID] // 0x0000000189933A60-0x0000000189933A80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001855421A0-0x0000000185542320
	// [XID] // 0x000000018993B5F0-0x000000018993B610
	public void InitEmpty() {} // 0x0000000185541590-0x00000001855416E0
	[BlackList] // 0x0000000189942690-0x00000001899426D0
	// [XID] // 0x0000000189942690-0x00000001899426D0
	public bool FromJson(JSONNode node) => default; // 0x0000000185541130-0x00000001855414B0
	// [XID] // 0x000000018994CE50-0x000000018994CE70
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185540030-0x0000000185540620
	// [XID] // 0x0000000189954660-0x0000000189954680
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC6F */, bool useObjectPool = false /* Metadata: 0x00AFAC73 */) => default; // 0x00000001855417C0-0x0000000185541AC0
	// [XID] // 0x000000018995BEE0-0x000000018995BF00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC74 */, bool useObjectPool = false /* Metadata: 0x00AFAC78 */) => default; // 0x0000000185540D50-0x0000000185541130
	[BlackList] // 0x0000000189963980-0x00000001899639C0
	// [XID] // 0x0000000189963980-0x00000001899639C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185540620-0x00000001855408F0
	// [XID] // 0x000000018996DCE0-0x000000018996DD00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185541BA0-0x0000000185541FE0
	[BlackList] // 0x00000001899758F0-0x0000000189975930
	// [XID] // 0x00000001899758F0-0x0000000189975930
	public virtual void AutoAllocTypeFields() {} // 0x00000001855409D0-0x0000000185540A70
	[BlackList] // 0x000000018997FEA0-0x000000018997FEE0
	// [XID] // 0x000000018997FEA0-0x000000018997FEE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185540A70-0x0000000185540B90
	[BlackList] // 0x000000018998AA40-0x000000018998AA80
	// [XID] // 0x000000018998AA40-0x000000018998AA80
	public virtual void ReturnToObjectPool() {} // 0x0000000185542610-0x00000001855426B0
	[BlackList] // 0x0000000189995590-0x00000001899955D0
	// [XID] // 0x0000000189995590-0x00000001899955D0
	public virtual void OnPoolAllocated() {} // 0x00000001855423C0-0x0000000185542460
	[BlackList] // 0x000000018999FDB0-0x000000018999FDF0
	// [XID] // 0x000000018999FDB0-0x000000018999FDF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185542320-0x00000001855423C0
}

