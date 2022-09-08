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
public class ConfigKeyInput : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18011
{
	// Fields
	private SimpleSafeInt32 keyIDRawNum; // 0x10
	private SimpleSafeInt32 inputKeyCodeRawNum; // 0x14
	private string _abilityName; // 0x18
	private SimpleSafeFloat abilityCDRawNum; // 0x20

	// Properties
	public int keyID { /* [XID] */ /* 0x0000000189738AD0-0x0000000189738AF0 */ get => default; /* [XID] */ /* 0x00000001897408C0-0x00000001897408E0 */ private set {} } // 0x0000000181C094B0-0x0000000181C09580 0x0000000181C085F0-0x0000000181C086D0
	public int inputKeyCode { /* [XID] */ /* 0x0000000189747C50-0x0000000189747C70 */ get => default; /* [XID] */ /* 0x000000018974F490-0x000000018974F4B0 */ private set {} } // 0x0000000181C093E0-0x0000000181C094B0 0x0000000181C09300-0x0000000181C093E0
	public string abilityName { /* [XID] */ /* 0x0000000189756AA0-0x0000000189756AC0 */ get => default; /* [XID] */ /* 0x000000018975DF50-0x000000018975DF70 */ private set {} } // 0x0000000181C09260-0x0000000181C09300 0x0000000181C09930-0x0000000181C099E0
	public float abilityCD { /* [XID] */ /* 0x00000001897656D0-0x00000001897656F0 */ get => default; /* [XID] */ /* 0x000000018976CF20-0x000000018976CF40 */ private set {} } // 0x0000000181C07AA0-0x0000000181C07B80 0x0000000181C08510-0x0000000181C085F0

	// Constructors
	public ConfigKeyInput() {} // 0x0000000181C09D00-0x0000000181C09DA0

	// Methods
	// [XID] // 0x00000001897743B0-0x00000001897743D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C099E0-0x0000000181C09B20
	// [XID] // 0x000000018977BCC0-0x000000018977BCE0
	public void InitEmpty() {} // 0x0000000181C08E20-0x0000000181C08F60
	[BlackList] // 0x00000001897836D0-0x0000000189783710
	// [XID] // 0x00000001897836D0-0x0000000189783710
	public bool FromJson(JSONNode node) => default; // 0x0000000181C08AA0-0x0000000181C08E20
	// [XID] // 0x000000018978DC90-0x000000018978DCB0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C07B80-0x0000000181C08080
	// [XID] // 0x0000000189795280-0x00000001897952A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8683 */, bool useObjectPool = false /* Metadata: 0x00AF8687 */) => default; // 0x0000000181C08F60-0x0000000181C09260
	// [XID] // 0x000000018979D650-0x000000018979D670
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8688 */, bool useObjectPool = false /* Metadata: 0x00AF868C */) => default; // 0x0000000181C086D0-0x0000000181C08AA0
	[BlackList] // 0x00000001897A4950-0x00000001897A4990
	// [XID] // 0x00000001897A4950-0x00000001897A4990
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C08080-0x0000000181C08350
	// [XID] // 0x00000001897AF230-0x00000001897AF250
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C09580-0x0000000181C09930
	[BlackList] // 0x00000001897B7070-0x00000001897B70B0
	// [XID] // 0x00000001897B7070-0x00000001897B70B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C08350-0x0000000181C083F0
	[BlackList] // 0x00000001897C1C30-0x00000001897C1C70
	// [XID] // 0x00000001897C1C30-0x00000001897C1C70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C083F0-0x0000000181C08510
	[BlackList] // 0x00000001897CC1D0-0x00000001897CC210
	// [XID] // 0x00000001897CC1D0-0x00000001897CC210
	public virtual void ReturnToObjectPool() {} // 0x0000000181C09C60-0x0000000181C09D00
	[BlackList] // 0x00000001897D6B00-0x00000001897D6B40
	// [XID] // 0x00000001897D6B00-0x00000001897D6B40
	public virtual void OnPoolAllocated() {} // 0x0000000181C09BC0-0x0000000181C09C60
	[BlackList] // 0x00000001897E13C0-0x00000001897E1400
	// [XID] // 0x00000001897E13C0-0x00000001897E1400
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C09B20-0x0000000181C09BC0
}

