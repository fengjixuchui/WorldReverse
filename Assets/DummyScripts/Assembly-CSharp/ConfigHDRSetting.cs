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
public class ConfigHDRSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18180
{
	// Fields
	private SimpleSafeFloat maxLuminosityRawNum; // 0x10
	private SimpleSafeFloat minMaxLuminosityRawNum; // 0x14
	private SimpleSafeFloat maxMaxLuminosityRawNum; // 0x18
	private SimpleSafeFloat stepMaxLuminosityRawNum; // 0x1C
	private SimpleSafeFloat UIPaperWhiteRawNum; // 0x20
	private SimpleSafeFloat minUIPaperWhiteRawNum; // 0x24
	private SimpleSafeFloat maxUIPaperWhiteRawNum; // 0x28
	private SimpleSafeFloat stepUIPaperWhiteRawNum; // 0x2C
	private SimpleSafeFloat ScenePaperWhiteRawNum; // 0x30
	private SimpleSafeFloat minScenePaperWhiteRawNum; // 0x34
	private SimpleSafeFloat maxScenePaperWhiteRawNum; // 0x38
	private SimpleSafeFloat stepScenePaperWhiteRawNum; // 0x3C

	// Properties
	public float maxLuminosity { /* [XID] */ /* 0x00000001898F33C0-0x00000001898F33E0 */ get => default; /* [XID] */ /* 0x00000001898FA9E0-0x00000001898FAA00 */ private set {} } // 0x000000018245FE30-0x000000018245FF10 0x000000018245F0B0-0x000000018245F190
	public float minMaxLuminosity { /* [XID] */ /* 0x0000000189902560-0x0000000189902580 */ get => default; /* [XID] */ /* 0x0000000189909B20-0x0000000189909B40 */ private set {} } // 0x0000000182460DC0-0x0000000182460EA0 0x000000018245F7B0-0x000000018245F890
	public float maxMaxLuminosity { /* [XID] */ /* 0x00000001899112E0-0x0000000189911300 */ get => default; /* [XID] */ /* 0x0000000189918E80-0x0000000189918EA0 */ private set {} } // 0x000000018245FFF0-0x00000001824600D0 0x000000018245FD50-0x000000018245FE30
	public float stepMaxLuminosity { /* [XID] */ /* 0x00000001899204F0-0x0000000189920510 */ get => default; /* [XID] */ /* 0x0000000189927DD0-0x0000000189927DF0 */ private set {} } // 0x000000018245FF10-0x000000018245FFF0 0x000000018245F190-0x000000018245F270
	public float UIPaperWhite { /* [XID] */ /* 0x000000018992F4C0-0x000000018992F4E0 */ get => default; /* [XID] */ /* 0x00000001899368F0-0x0000000189936910 */ private set {} } // 0x000000018245F510-0x000000018245F5F0 0x000000018245F430-0x000000018245F510
	public float minUIPaperWhite { /* [XID] */ /* 0x000000018993E490-0x000000018993E4B0 */ get => default; /* [XID] */ /* 0x0000000189945B00-0x0000000189945B20 */ private set {} } // 0x000000018245F270-0x000000018245F350 0x000000018245CCE0-0x000000018245CDC0
	public float maxUIPaperWhite { /* [XID] */ /* 0x000000018994CF50-0x000000018994CF70 */ get => default; /* [XID] */ /* 0x00000001899546E0-0x0000000189954700 */ private set {} } // 0x000000018245E180-0x000000018245E260 0x00000001824600D0-0x00000001824601B0
	public float stepUIPaperWhite { /* [XID] */ /* 0x000000018995C000-0x000000018995C020 */ get => default; /* [XID] */ /* 0x0000000189963A20-0x0000000189963A40 */ private set {} } // 0x000000018245E0A0-0x000000018245E180 0x000000018245EB70-0x000000018245EC50
	public float ScenePaperWhite { /* [XID] */ /* 0x000000018996AFB0-0x000000018996AFD0 */ get => default; /* [XID] */ /* 0x0000000189972A70-0x0000000189972A90 */ private set {} } // 0x0000000182460990-0x0000000182460A70 0x000000018245DFC0-0x000000018245E0A0
	public float minScenePaperWhite { /* [XID] */ /* 0x000000018997A2D0-0x000000018997A2F0 */ get => default; /* [XID] */ /* 0x0000000189981AA0-0x0000000189981AC0 */ private set {} } // 0x000000018245F890-0x000000018245F970 0x000000018245E340-0x000000018245E420
	public float maxScenePaperWhite { /* [XID] */ /* 0x00000001899893E0-0x0000000189989400 */ get => default; /* [XID] */ /* 0x0000000189990BF0-0x0000000189990C10 */ private set {} } // 0x000000018245EC50-0x000000018245ED30 0x000000018245FC70-0x000000018245FD50
	public float stepScenePaperWhite { /* [XID] */ /* 0x00000001899986F0-0x0000000189998710 */ get => default; /* [XID] */ /* 0x000000018999FF50-0x000000018999FF70 */ private set {} } // 0x000000018245E260-0x000000018245E340 0x000000018245F350-0x000000018245F430

	// Constructors
	public ConfigHDRSetting() {} // 0x0000000182460F40-0x00000001824610C0

	// Methods
	// [XID] // 0x00000001899A7B20-0x00000001899A7B40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182460A70-0x0000000182460C80
	// [XID] // 0x00000001899AF330-0x00000001899AF350
	public void InitEmpty() {} // 0x000000018245F5F0-0x000000018245F7B0
	[BlackList] // 0x00000001899B6730-0x00000001899B6770
	// [XID] // 0x00000001899B6730-0x00000001899B6770
	public bool FromJson(JSONNode node) => default; // 0x000000018245ED30-0x000000018245F0B0
	// [XID] // 0x00000001899C1210-0x00000001899C1230
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018245CDC0-0x000000018245DA90
	// [XID] // 0x00000001899C8860-0x00000001899C8880
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8E1B */, bool useObjectPool = false /* Metadata: 0x00AF8E1F */) => default; // 0x000000018245F970-0x000000018245FC70
	// [XID] // 0x00000001899D0250-0x00000001899D0270
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8E20 */, bool useObjectPool = false /* Metadata: 0x00AF8E24 */) => default; // 0x000000018245E420-0x000000018245EB70
	[BlackList] // 0x00000001899D76D0-0x00000001899D7710
	// [XID] // 0x00000001899D76D0-0x00000001899D7710
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018245DA90-0x000000018245DD60
	// [XID] // 0x00000001899E2020-0x00000001899E2040
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001824601B0-0x0000000182460990
	[BlackList] // 0x00000001899E94A0-0x00000001899E94E0
	// [XID] // 0x00000001899E94A0-0x00000001899E94E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018245DD60-0x000000018245DE00
	[BlackList] // 0x00000001899F4170-0x00000001899F41B0
	// [XID] // 0x00000001899F4170-0x00000001899F41B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018245DE00-0x000000018245DFC0
	[BlackList] // 0x00000001899FE4D0-0x00000001899FE510
	// [XID] // 0x00000001899FE4D0-0x00000001899FE510
	public virtual void ReturnToObjectPool() {} // 0x0000000182460EA0-0x0000000182460F40
	[BlackList] // 0x0000000189A08990-0x0000000189A089D0
	// [XID] // 0x0000000189A08990-0x0000000189A089D0
	public virtual void OnPoolAllocated() {} // 0x0000000182460D20-0x0000000182460DC0
	[BlackList] // 0x0000000189A13160-0x0000000189A131A0
	// [XID] // 0x0000000189A13160-0x0000000189A131A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182460C80-0x0000000182460D20
}

