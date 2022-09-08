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
public class ConfigDialogScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19059
{
	// Fields
	private uint _id; // 0x10
	private uint[] _nextDialogs; // 0x18
	private TalkShowType _talkShowType; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private TalkRoleEx _talkRole; // 0x28
	private uint talkContentTextMapHash; // 0x30
	private uint talkTitleTextMapHash; // 0x34
	private uint talkRoleNameTextMapHash; // 0x38
	private string _talkAssetPath; // 0x40
	private string _talkAssetPath_Alter; // 0x48
	private string _talkAudioName; // 0x50
	private string _actionBefore; // 0x58
	private string _actionWhile; // 0x60
	private string _actionAfter; // 0x68
	private float _showDuration; // 0x70
	private string _optionIcon; // 0x78

	// Properties
	public uint id { /* [XID] */ /* 0x000000018972BEC0-0x000000018972BEE0 */ get => default; /* [XID] */ /* 0x0000000189BA2090-0x0000000189BA20B0 */ private set {} } // 0x000000018176C610-0x000000018176C6B0 0x000000018176AC80-0x000000018176AD30
	public uint[] nextDialogs { /* [XID] */ /* 0x0000000189BA9560-0x0000000189BA9580 */ get => default; /* [XID] */ /* 0x0000000189BB0D10-0x0000000189BB0D30 */ private set {} } // 0x000000018176ABE0-0x000000018176AC80 0x000000018176A260-0x000000018176A310
	public TalkShowType talkShowType { /* [XID] */ /* 0x0000000189BB7EA0-0x0000000189BB7EC0 */ get => default; /* [XID] */ /* 0x0000000189BBF650-0x0000000189BBF670 */ private set {} } // 0x000000018176A3B0-0x000000018176A450 0x0000000181768EB0-0x0000000181768F60
	public TalkRoleEx talkRole { /* [XID] */ /* 0x0000000189BC7260-0x0000000189BC7280 */ get => default; /* [XID] */ /* 0x0000000189BCEFB0-0x0000000189BCEFD0 */ private set {} } // 0x000000018176A310-0x000000018176A3B0 0x000000018176A690-0x000000018176A740
	public string talkContent { /* [XID] */ /* 0x0000000189BD6320-0x0000000189BD6340 */ get => default; } // 0x0000000181768F60-0x0000000181769080 
	public string talkTitle { /* [XID] */ /* 0x0000000189BDDE00-0x0000000189BDDE20 */ get => default; } // 0x000000018176A570-0x000000018176A690 
	public string talkRoleName { /* [XID] */ /* 0x00000001895EAA90-0x00000001895EAAB0 */ get => default; } // 0x0000000181769D10-0x0000000181769E30 
	public string talkAssetPath { /* [XID] */ /* 0x00000001895F1ED0-0x00000001895F1EF0 */ get => default; /* [XID] */ /* 0x00000001895F98A0-0x00000001895F98C0 */ private set {} } // 0x0000000181767AF0-0x0000000181767B90 0x0000000181769C60-0x0000000181769D10
	public string talkAssetPath_Alter { /* [XID] */ /* 0x0000000189600FE0-0x0000000189601000 */ get => default; /* [XID] */ /* 0x0000000189608970-0x0000000189608990 */ private set {} } // 0x000000018176A8A0-0x000000018176A940 0x000000018176B030-0x000000018176B0E0
	public string talkAudioName { /* [XID] */ /* 0x00000001896100F0-0x0000000189610110 */ get => default; /* [XID] */ /* 0x00000001896173B0-0x00000001896173D0 */ private set {} } // 0x000000018176A940-0x000000018176A9E0 0x0000000181769E30-0x0000000181769EE0
	public string actionBefore { /* [XID] */ /* 0x0000000189916A00-0x0000000189916A20 */ get => default; /* [XID] */ /* 0x0000000189626400-0x0000000189626420 */ private set {} } // 0x0000000181768B70-0x0000000181768C10 0x0000000181769120-0x00000001817691D0
	public string actionWhile { /* [XID] */ /* 0x000000018962DD90-0x000000018962DDB0 */ get => default; /* [XID] */ /* 0x00000001896359D0-0x00000001896359F0 */ private set {} } // 0x000000018176C000-0x000000018176C0A0 0x000000018176B5C0-0x000000018176B670
	public string actionAfter { /* [XID] */ /* 0x000000018963D0B0-0x000000018963D0D0 */ get => default; /* [XID] */ /* 0x00000001896445F0-0x0000000189644610 */ private set {} } // 0x0000000181769080-0x0000000181769120 0x000000018176A7F0-0x000000018176A8A0
	public float showDuration { /* [XID] */ /* 0x000000018964BE70-0x000000018964BE90 */ get => default; /* [XID] */ /* 0x00000001896534E0-0x0000000189653500 */ private set {} } // 0x000000018176A740-0x000000018176A7F0 0x0000000181768E00-0x0000000181768EB0
	public string optionIcon { /* [XID] */ /* 0x000000018965AD30-0x000000018965AD50 */ get => default; /* [XID] */ /* 0x0000000189662240-0x0000000189662260 */ private set {} } // 0x000000018176C7B0-0x000000018176C850 0x000000018176B2B0-0x000000018176B360
	public bool isForceSelect { /* [XID] */ /* 0x00000001896DF820-0x00000001896DF840 */ get => default; } // 0x000000018176A9E0-0x000000018176AA90 
	public uint nextDialog { /* [XID] */ /* 0x000000018965FF70-0x000000018965FF90 */ get => default; [BlackList] /* 0x000000018970BD90-0x000000018970BDD0 */ /* [XID] */ /* 0x000000018970BD90-0x000000018970BDD0 */ set {} } // 0x000000018176C6B0-0x000000018176C7B0 0x000000018176B510-0x000000018176B5C0

	// Constructors
	public ConfigDialogScheme() {} // 0x000000018176C8F0-0x000000018176C950

	// Methods
	// [XID] // 0x0000000189669E40-0x0000000189669E60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018176C260-0x000000018176C4D0
	// [XID] // 0x0000000189671AE0-0x0000000189671B00
	public void InitEmpty() {} // 0x000000018176AA90-0x000000018176ABE0
	[BlackList] // 0x0000000189679230-0x0000000189679270
	// [XID] // 0x0000000189679230-0x0000000189679270
	public bool FromJson(JSONNode node) => default; // 0x0000000181769EE0-0x000000018176A260
	// [XID] // 0x0000000189683730-0x0000000189683750
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181767B90-0x00000001817688A0
	// [XID] // 0x0000000189AAD9A0-0x0000000189AAD9C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB911 */, bool useObjectPool = false /* Metadata: 0x00AFB915 */) => default; // 0x000000018176AD30-0x000000018176B030
	// [XID] // 0x0000000189693120-0x0000000189693140
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB916 */, bool useObjectPool = false /* Metadata: 0x00AFB91A */) => default; // 0x00000001817691D0-0x0000000181769C60
	[BlackList] // 0x000000018969A2F0-0x000000018969A330
	// [XID] // 0x000000018969A2F0-0x000000018969A330
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001817688A0-0x0000000181768B70
	// [XID] // 0x00000001896A4700-0x00000001896A4720
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018176B670-0x000000018176C000
	[BlackList] // 0x00000001896ABE70-0x00000001896ABEB0
	// [XID] // 0x00000001896ABE70-0x00000001896ABEB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181768C10-0x0000000181768CB0
	[BlackList] // 0x00000001896B6360-0x00000001896B63A0
	// [XID] // 0x00000001896B6360-0x00000001896B63A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181768CB0-0x0000000181768E00
	[BlackList] // 0x00000001896C0420-0x00000001896C0460
	// [XID] // 0x00000001896C0420-0x00000001896C0460
	public virtual void ReturnToObjectPool() {} // 0x000000018176C850-0x000000018176C8F0
	[BlackList] // 0x00000001896CA870-0x00000001896CA8B0
	// [XID] // 0x00000001896CA870-0x00000001896CA8B0
	public virtual void OnPoolAllocated() {} // 0x000000018176C570-0x000000018176C610
	[BlackList] // 0x00000001896D4F60-0x00000001896D4FA0
	// [XID] // 0x00000001896D4F60-0x00000001896D4FA0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018176C4D0-0x000000018176C570
	// [XID] // 0x00000001896E6BE0-0x00000001896E6C00
	public string GetRealTalkRoleName(uint mainQuestId = 0 /* Metadata: 0x00AFB91B */) => default; // 0x000000018176B360-0x000000018176B510
	// [XID] // 0x00000001896EE110-0x00000001896EE130
	public string GetRealTalkRoleTitle(uint mainQuestId = 0 /* Metadata: 0x00AFB91F */) => default; // 0x000000018176C0A0-0x000000018176C260
	// [XID] // 0x00000001896F5940-0x00000001896F5960
	public uint GetTalkRoleID(uint mainQuestId = 0 /* Metadata: 0x00AFB923 */) => default; // 0x000000018176B0E0-0x000000018176B2B0
	// [XID] // 0x00000001896FD130-0x00000001896FD150
	public string GetTalkAssetByMale(bool isMale) => default; // 0x000000018176A450-0x000000018176A570
}

