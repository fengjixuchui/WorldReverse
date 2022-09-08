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
public class ConfigDirectionByWorld : ConfigBornDirectionType, IAutoAllocRecycle // TypeDefIndex: 17848
{
	// Fields
	private MoleMole.Config.Vector _eularAngles; // 0x38

	// Properties
	public MoleMole.Config.Vector eularAngles { /* [XID] */ /* 0x000000018989B4F0-0x000000018989B510 */ get => default; /* [XID] */ /* 0x000000018993B7F0-0x000000018993B810 */ private set {} } // 0x0000000182AC04E0-0x0000000182AC05C0 0x0000000182ABE970-0x0000000182ABEA40

	// Constructors
	public ConfigDirectionByWorld() {} // 0x0000000182AC09B0-0x0000000182AC0A10

	// Methods
	// [XID] // 0x0000000189942890-0x00000001899428B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AC0820-0x0000000182AC0910
	// [XID] // 0x000000018994A0E0-0x000000018994A100
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182AC0430-0x0000000182AC04E0
	// [XID] // 0x0000000189951C10-0x0000000189951C30
	public override ConfigBornDirectionType Clone(bool useObjectPool = false /* Metadata: 0x00AF7EE9 */) => default; // 0x0000000182AC0040-0x0000000182AC0120
	// [XID] // 0x00000001899590D0-0x00000001899590F0
	public override int GetHashNum() => default; // 0x0000000182ABEF90-0x0000000182ABF060
	// [XID] // 0x0000000189960960-0x0000000189960980
	public override void InitEmpty() {} // 0x0000000182ABFAA0-0x0000000182ABFB70
	[BlackList] // 0x0000000189968120-0x0000000189968160
	// [XID] // 0x0000000189968120-0x0000000189968160
	public override bool FromJson(JSONNode node) => default; // 0x0000000182ABF490-0x0000000182ABF810
	// [XID] // 0x0000000189972AD0-0x0000000189972AF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182ABE750-0x0000000182ABE970
	[BlackList] // 0x000000018997A370-0x000000018997A3B0
	// [XID] // 0x000000018997A370-0x000000018997A3B0
	public static new ConfigDirectionByWorld ParseFromJson(JSONNode node) => default; // 0x0000000182AC0180-0x0000000182AC03D0
	// [XID] // 0x0000000189984810-0x0000000189984830
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7EEA */, bool useObjectPool = false /* Metadata: 0x00AF7EEE */) => default; // 0x0000000182ABFD40-0x0000000182AC0040
	// [XID] // 0x000000018998C270-0x000000018998C290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7EEF */, bool useObjectPool = false /* Metadata: 0x00AF7EF3 */) => default; // 0x0000000182ABF140-0x0000000182ABF390
	// [XID] // 0x0000000189993FF0-0x0000000189994010
	public static new ConfigDirectionByWorld ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7EF4 */, bool useObjectPool = false /* Metadata: 0x00AF7EF8 */) => default; // 0x0000000182ABF810-0x0000000182ABFA30
	[BlackList] // 0x000000018999B7E0-0x000000018999B820
	// [XID] // 0x000000018999B7E0-0x000000018999B820
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182ABEA40-0x0000000182ABED10
	// [XID] // 0x00000001899A63B0-0x00000001899A63D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AC05C0-0x0000000182AC0820
	[BlackList] // 0x00000001899ADA80-0x00000001899ADAC0
	// [XID] // 0x00000001899ADA80-0x00000001899ADAC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182ABFC50-0x0000000182ABFD40
	[BlackList] // 0x00000001899B7FB0-0x00000001899B7FF0
	// [XID] // 0x00000001899B7FB0-0x00000001899B7FF0
	public override void AutoAllocTypeFields() {} // 0x0000000182ABED10-0x0000000182ABEDB0
	[BlackList] // 0x00000001899C2AE0-0x00000001899C2B20
	// [XID] // 0x00000001899C2AE0-0x00000001899C2B20
	public override void AutoRecycleTypeFields() {} // 0x0000000182ABEDB0-0x0000000182ABEE70
	[BlackList] // 0x00000001899CD250-0x00000001899CD290
	// [XID] // 0x00000001899CD250-0x00000001899CD290
	public override void ReturnToObjectPool() {} // 0x0000000182AC0910-0x0000000182AC09B0
}

