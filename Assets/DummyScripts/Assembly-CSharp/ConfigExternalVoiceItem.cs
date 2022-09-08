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
public class ConfigExternalVoiceItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18075
{
	// Fields
	private string __guid; // 0x10
	private SimpleSafeFloat _playRateRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigExternalVoiceInferiorItem[] __interruptedGuids; // 0x20
	private SimpleSafeInt32 _queueUpConfigRawNum; // 0x28
	private string __gameTrigger; // 0x30
	private SimpleSafeUInt32 _gameTriggerArgsRawNum; // 0x38
	private SimpleSafeInt32 _personalConfigRawNum; // 0x3C
	private SimpleSafeInt32 _viewConfigRawNum; // 0x40
	private bool __clearAll; // 0x44
	private bool __isGlobalStop; // 0x45
	private bool __isPlayOnTeam; // 0x46
	private SimpleSafeInt32 _avoidRepeatRawNum; // 0x48
	private string __parentID; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigExternalVoiceSound[] __sourceNames; // 0x58

	// Properties
	public string _guid { /* [XID] */ /* 0x0000000189621E20-0x0000000189621E40 */ get => default; /* [XID] */ /* 0x00000001896297F0-0x0000000189629810 */ private set {} } // 0x0000000182C867E0-0x0000000182C86880 0x0000000182C86E00-0x0000000182C86EB0
	public float _playRate { /* [XID] */ /* 0x00000001896310E0-0x0000000189631100 */ get => default; /* [XID] */ /* 0x0000000189638AD0-0x0000000189638AF0 */ private set {} } // 0x0000000182C878B0-0x0000000182C87990 0x0000000182C87D70-0x0000000182C87E50
	public ConfigExternalVoiceInferiorItem[] _interruptedGuids { /* [XID] */ /* 0x000000018963FEF0-0x000000018963FF10 */ get => default; /* [XID] */ /* 0x00000001896477B0-0x00000001896477D0 */ private set {} } // 0x0000000182C86D60-0x0000000182C86E00 0x0000000182C87100-0x0000000182C871B0
	public int _queueUpConfig { /* [XID] */ /* 0x000000018964ED60-0x000000018964ED80 */ get => default; /* [XID] */ /* 0x0000000189656670-0x0000000189656690 */ private set {} } // 0x0000000182C87CA0-0x0000000182C87D70 0x0000000182C86650-0x0000000182C86730
	public string _gameTrigger { /* [XID] */ /* 0x000000018965DD50-0x000000018965DD70 */ get => default; /* [XID] */ /* 0x0000000189665470-0x0000000189665490 */ private set {} } // 0x0000000182C87A40-0x0000000182C87AE0 0x0000000182C86730-0x0000000182C867E0
	public uint _gameTriggerArgs { /* [XID] */ /* 0x000000018966CBA0-0x000000018966CBC0 */ get => default; /* [XID] */ /* 0x00000001896749D0-0x00000001896749F0 */ private set {} } // 0x0000000182C85970-0x0000000182C85A40 0x0000000182C87BC0-0x0000000182C87CA0
	public int _personalConfig { /* [XID] */ /* 0x000000018967C2E0-0x000000018967C300 */ get => default; /* [XID] */ /* 0x0000000189683950-0x0000000189683970 */ private set {} } // 0x0000000182C86F50-0x0000000182C87020 0x0000000182C87AE0-0x0000000182C87BC0
	public int _viewConfig { /* [XID] */ /* 0x000000018968B690-0x000000018968B6B0 */ get => default; /* [XID] */ /* 0x0000000189693240-0x0000000189693260 */ private set {} } // 0x0000000182C88850-0x0000000182C88920 0x0000000182C87720-0x0000000182C87800
	public bool _clearAll { /* [XID] */ /* 0x000000018969A470-0x000000018969A490 */ get => default; /* [XID] */ /* 0x00000001896A1D40-0x00000001896A1D60 */ private set {} } // 0x0000000182C85A40-0x0000000182C85AE0 0x0000000182C86880-0x0000000182C86930
	public bool _isGlobalStop { /* [XID] */ /* 0x00000001896A9160-0x00000001896A9180 */ get => default; /* [XID] */ /* 0x00000001896B0310-0x00000001896B0330 */ private set {} } // 0x0000000182C87380-0x0000000182C87420 0x0000000182C87990-0x0000000182C87A40
	public bool _isPlayOnTeam { /* [XID] */ /* 0x00000001896B7BD0-0x00000001896B7BF0 */ get => default; /* [XID] */ /* 0x00000001896BEB90-0x00000001896BEBB0 */ private set {} } // 0x0000000182C85AE0-0x0000000182C85B80 0x0000000182C87800-0x0000000182C878B0
	public int _avoidRepeat { /* [XID] */ /* 0x00000001896C6610-0x00000001896C6630 */ get => default; /* [XID] */ /* 0x00000001896CDB30-0x00000001896CDB50 */ private set {} } // 0x0000000182C88D50-0x0000000182C88E20 0x0000000182C87020-0x0000000182C87100
	public string _parentID { /* [XID] */ /* 0x00000001896D5120-0x00000001896D5140 */ get => default; /* [XID] */ /* 0x00000001896DC700-0x00000001896DC720 */ private set {} } // 0x0000000182C85B80-0x0000000182C85C20 0x0000000182C88920-0x0000000182C889D0
	public ConfigExternalVoiceSound[] _sourceNames { /* [XID] */ /* 0x00000001896E4010-0x00000001896E4030 */ get => default; /* [XID] */ /* 0x00000001896EB4A0-0x00000001896EB4C0 */ private set {} } // 0x0000000182C86EB0-0x0000000182C86F50 0x0000000182C86930-0x0000000182C869E0

	// Constructors
	public ConfigExternalVoiceItem() {} // 0x0000000182C88EC0-0x0000000182C88F20

	// Methods
	// [XID] // 0x00000001896F27B0-0x00000001896F27D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C889D0-0x0000000182C88C10
	// [XID] // 0x00000001896FA150-0x00000001896FA170
	public void InitEmpty() {} // 0x0000000182C871B0-0x0000000182C87380
	[BlackList] // 0x0000000189701900-0x0000000189701940
	// [XID] // 0x0000000189701900-0x0000000189701940
	public bool FromJson(JSONNode node) => default; // 0x0000000182C869E0-0x0000000182C86D60
	// [XID] // 0x000000018970BFD0-0x000000018970BFF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C84670-0x0000000182C85460
	// [XID] // 0x0000000189713900-0x0000000189713920
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A2D */, bool useObjectPool = false /* Metadata: 0x00AF8A31 */) => default; // 0x0000000182C87420-0x0000000182C87720
	// [XID] // 0x000000018971B180-0x000000018971B1A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A32 */, bool useObjectPool = false /* Metadata: 0x00AF8A36 */) => default; // 0x0000000182C85C20-0x0000000182C86650
	[BlackList] // 0x00000001897224E0-0x0000000189722520
	// [XID] // 0x00000001897224E0-0x0000000189722520
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C85460-0x0000000182C85730
	// [XID] // 0x000000018972CB00-0x000000018972CB20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C87E50-0x0000000182C88850
	[BlackList] // 0x0000000189734270-0x00000001897342B0
	// [XID] // 0x0000000189734270-0x00000001897342B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C85730-0x0000000182C857D0
	[BlackList] // 0x000000018973F180-0x000000018973F1C0
	// [XID] // 0x000000018973F180-0x000000018973F1C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C857D0-0x0000000182C85970
	[BlackList] // 0x00000001897496C0-0x0000000189749700
	// [XID] // 0x00000001897496C0-0x0000000189749700
	public virtual void ReturnToObjectPool() {} // 0x0000000182C88E20-0x0000000182C88EC0
	[BlackList] // 0x0000000189753A20-0x0000000189753A60
	// [XID] // 0x0000000189753A20-0x0000000189753A60
	public virtual void OnPoolAllocated() {} // 0x0000000182C88CB0-0x0000000182C88D50
	[BlackList] // 0x000000018975DEF0-0x000000018975DF30
	// [XID] // 0x000000018975DEF0-0x000000018975DF30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C88C10-0x0000000182C88CB0
}

