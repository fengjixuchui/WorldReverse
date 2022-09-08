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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class QuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15969
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected uint _subId; // 0x10
	protected uint _mainId; // 0x14
	protected int _order; // 0x18
	protected uint _subIdSet; // 0x1C
	protected bool _isMpBlock; // 0x20
	protected uint _descTextMapHash; // 0x24
	protected uint _stepDescTextMapHash; // 0x28
	protected uint _guideTipsTextMapHash; // 0x2C
	protected QuestShowType _showType; // 0x30
	protected BanGroupType _banType; // 0x34
	protected LogicType _acceptCondComb; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestCond[] _acceptCond; // 0x40
	protected LogicType _finishCondComb; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestContent[] _finishCond; // 0x50
	protected LogicType _failCondComb; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestContent[] _failCond; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestGuide _guide; // 0x68
	protected ShowQuestGuideType _showGuide; // 0x70
	protected bool _finishParent; // 0x74
	protected bool _failParent; // 0x75
	protected QuestShowType _failParentShow; // 0x78
	protected bool _isRewind; // 0x7C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestExec[] _finishExec; // 0x80
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestExec[] _failExec; // 0x88
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestExec[] _beginExec; // 0x90
	protected uint[] _exclusiveNpcList; // 0x98
	protected uint[] _sharedNpcList; // 0xA0
	protected uint _exclusiveNpcPriority; // 0xA8
	protected uint[] _trialAvatarList; // 0xB0
	protected uint[] _exclusivePlaceList; // 0xB8

	// Properties
	public uint subId { /* [XID] */ /* 0x000000018998AFC0-0x000000018998AFE0 */ get => default; /* [XID] */ /* 0x0000000189992950-0x0000000189992970 */ protected set {} } // 0x0000000183AFB4A0-0x0000000183AFB540 0x0000000183AFB9C0-0x0000000183AFBA70
	public uint mainId { /* [XID] */ /* 0x000000018999A6D0-0x000000018999A6F0 */ get => default; /* [XID] */ /* 0x00000001899A1D50-0x00000001899A1D70 */ protected set {} } // 0x0000000183AFB880-0x0000000183AFB920 0x0000000183AF9C00-0x0000000183AF9CB0
	public int order { /* [XID] */ /* 0x00000001899A9680-0x00000001899A96A0 */ get => default; /* [XID] */ /* 0x00000001899B10D0-0x00000001899B10F0 */ protected set {} } // 0x0000000183AF4C80-0x0000000183AF4D20 0x0000000183AF9880-0x0000000183AF9930
	public uint subIdSet { /* [XID] */ /* 0x00000001899B8330-0x00000001899B8350 */ get => default; /* [XID] */ /* 0x00000001899BFE50-0x00000001899BFE70 */ protected set {} } // 0x0000000183AF4E70-0x0000000183AF4F10 0x0000000183AF8CC0-0x0000000183AF8D70
	public bool isMpBlock { /* [XID] */ /* 0x00000001899C7630-0x00000001899C7650 */ get => default; /* [XID] */ /* 0x00000001899CEC40-0x00000001899CEC60 */ protected set {} } // 0x0000000183AFB920-0x0000000183AFB9C0 0x0000000183AF9460-0x0000000183AF9510
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899D63B0-0x00000001899D63D0 */ get => default; /* [XID] */ /* 0x00000001899DD840-0x00000001899DD860 */ protected set {} } // 0x0000000183AFB690-0x0000000183AFB730 0x0000000183AF4BD0-0x0000000183AF4C80
	public string desc { /* [XID] */ /* 0x00000001899E5660-0x00000001899E5680 */ get => default; } // 0x0000000183AF9650-0x0000000183AF97D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint stepDescTextMapHash { /* [XID] */ /* 0x00000001899EC850-0x00000001899EC870 */ get => default; /* [XID] */ /* 0x00000001899F45B0-0x00000001899F45D0 */ protected set {} } // 0x0000000183AF49E0-0x0000000183AF4A80 0x0000000183AF9050-0x0000000183AF9100
	public string stepDesc { /* [XID] */ /* 0x00000001899FBC30-0x00000001899FBC50 */ get => default; } // 0x0000000183AF8ED0-0x0000000183AF9050 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint guideTipsTextMapHash { /* [XID] */ /* 0x0000000189A02F90-0x0000000189A02FB0 */ get => default; /* [XID] */ /* 0x0000000189A0A520-0x0000000189A0A540 */ protected set {} } // 0x0000000183AF95B0-0x0000000183AF9650 0x0000000183AF9B50-0x0000000183AF9C00
	public string guideTips { /* [XID] */ /* 0x0000000189A11E60-0x0000000189A11E80 */ get => default; } // 0x0000000183AF9930-0x0000000183AF9AB0 
	public QuestShowType showType { /* [XID] */ /* 0x0000000189A19130-0x0000000189A19150 */ get => default; /* [XID] */ /* 0x0000000189A208D0-0x0000000189A208F0 */ protected set {} } // 0x0000000183AF8B70-0x0000000183AF8C10 0x0000000183AF4890-0x0000000183AF4940
	public BanGroupType banType { /* [XID] */ /* 0x0000000189A27CC0-0x0000000189A27CE0 */ get => default; /* [XID] */ /* 0x0000000189A2F370-0x0000000189A2F390 */ protected set {} } // 0x0000000183AFC240-0x0000000183AFC2E0 0x0000000183AF93B0-0x0000000183AF9460
	public LogicType acceptCondComb { /* [XID] */ /* 0x0000000189A36DF0-0x0000000189A36E10 */ get => default; /* [XID] */ /* 0x0000000189A3E410-0x0000000189A3E430 */ protected set {} } // 0x0000000183AF4940-0x0000000183AF49E0 0x0000000183AFB3F0-0x0000000183AFB4A0
	public QuestCond[] acceptCond { /* [XID] */ /* 0x0000000189A45AA0-0x0000000189A45AC0 */ get => default; /* [XID] */ /* 0x0000000189A4D1E0-0x0000000189A4D200 */ protected set {} } // 0x0000000183AF4A80-0x0000000183AF4B20 0x0000000183AFBBC0-0x0000000183AFBC70
	public LogicType finishCondComb { /* [XID] */ /* 0x0000000189A54910-0x0000000189A54930 */ get => default; /* [XID] */ /* 0x0000000189A5C3C0-0x0000000189A5C3E0 */ protected set {} } // 0x0000000183AFBE70-0x0000000183AFBF10 0x0000000183AF8C10-0x0000000183AF8CC0
	public QuestContent[] finishCond { /* [XID] */ /* 0x0000000189A63D70-0x0000000189A63D90 */ get => default; /* [XID] */ /* 0x0000000189A6B650-0x0000000189A6B670 */ protected set {} } // 0x0000000183AFB5F0-0x0000000183AFB690 0x0000000183AF8E20-0x0000000183AF8ED0
	public LogicType failCondComb { /* [XID] */ /* 0x0000000189A72DA0-0x0000000189A72DC0 */ get => default; /* [XID] */ /* 0x0000000189A7A910-0x0000000189A7A930 */ protected set {} } // 0x0000000183AFBD20-0x0000000183AFBDC0 0x0000000183AFBC70-0x0000000183AFBD20
	public QuestContent[] failCond { /* [XID] */ /* 0x0000000189A81DB0-0x0000000189A81DD0 */ get => default; /* [XID] */ /* 0x0000000189A898B0-0x0000000189A898D0 */ protected set {} } // 0x0000000183AF9510-0x0000000183AF95B0 0x0000000183AF8D70-0x0000000183AF8E20
	public QuestGuide guide { /* [XID] */ /* 0x0000000189A90FB0-0x0000000189A90FD0 */ get => default; /* [XID] */ /* 0x0000000189A98900-0x0000000189A98920 */ protected set {} } // 0x0000000183AFBF10-0x0000000183AFBFB0 0x0000000183AFB540-0x0000000183AFB5F0
	public ShowQuestGuideType showGuide { /* [XID] */ /* 0x0000000189A9FCB0-0x0000000189A9FCD0 */ get => default; /* [XID] */ /* 0x0000000189AA73E0-0x0000000189AA7400 */ protected set {} } // 0x0000000183AFBA70-0x0000000183AFBB10 0x0000000183AF97D0-0x0000000183AF9880
	public bool finishParent { /* [XID] */ /* 0x0000000189AAEB40-0x0000000189AAEB60 */ get => default; /* [XID] */ /* 0x0000000189AB6460-0x0000000189AB6480 */ protected set {} } // 0x0000000183AFB730-0x0000000183AFB7D0 0x0000000183AF9250-0x0000000183AF9300
	public bool failParent { /* [XID] */ /* 0x0000000189ABDF30-0x0000000189ABDF50 */ get => default; /* [XID] */ /* 0x0000000189AC5A50-0x0000000189AC5A70 */ protected set {} } // 0x0000000183AF9100-0x0000000183AF91A0 0x0000000183AF8AC0-0x0000000183AF8B70
	public QuestShowType failParentShow { /* [XID] */ /* 0x0000000189ACCFC0-0x0000000189ACCFE0 */ get => default; /* [XID] */ /* 0x0000000189AD4D40-0x0000000189AD4D60 */ protected set {} } // 0x0000000183AF9AB0-0x0000000183AF9B50 0x0000000183AFB7D0-0x0000000183AFB880
	public bool isRewind { /* [XID] */ /* 0x0000000189ADC600-0x0000000189ADC620 */ get => default; /* [XID] */ /* 0x0000000189AE3F70-0x0000000189AE3F90 */ protected set {} } // 0x0000000183AFC1A0-0x0000000183AFC240 0x0000000183AF8A10-0x0000000183AF8AC0
	public QuestExec[] finishExec { /* [XID] */ /* 0x0000000189AEB810-0x0000000189AEB830 */ get => default; /* [XID] */ /* 0x0000000189AF3190-0x0000000189AF31B0 */ protected set {} } // 0x0000000183AF4530-0x0000000183AF45E0 0x0000000183AF8960-0x0000000183AF8A10
	public QuestExec[] failExec { /* [XID] */ /* 0x0000000189AFAA60-0x0000000189AFAA80 */ get => default; /* [XID] */ /* 0x0000000189B02010-0x0000000189B02030 */ protected set {} } // 0x0000000183AF9CB0-0x0000000183AF9D60 0x0000000183AF4F10-0x0000000183AF4FC0
	public QuestExec[] beginExec { /* [XID] */ /* 0x0000000189B094D0-0x0000000189B094F0 */ get => default; /* [XID] */ /* 0x0000000189B10FB0-0x0000000189B10FD0 */ protected set {} } // 0x0000000183AFBDC0-0x0000000183AFBE70 0x0000000183AF4B20-0x0000000183AF4BD0
	public uint[] exclusiveNpcList { /* [XID] */ /* 0x0000000189B18280-0x0000000189B182A0 */ get => default; /* [XID] */ /* 0x0000000189B1F8E0-0x0000000189B1F900 */ protected set {} } // 0x0000000183AF9300-0x0000000183AF93B0 0x0000000183AFC0F0-0x0000000183AFC1A0
	public uint[] sharedNpcList { /* [XID] */ /* 0x0000000189B27100-0x0000000189B27120 */ get => default; /* [XID] */ /* 0x0000000189B2E2B0-0x0000000189B2E2D0 */ protected set {} } // 0x0000000183AF4D20-0x0000000183AF4DD0 0x0000000183AF91A0-0x0000000183AF9250
	public uint exclusiveNpcPriority { /* [XID] */ /* 0x0000000189B35700-0x0000000189B35720 */ get => default; /* [XID] */ /* 0x0000000189B3CF40-0x0000000189B3CF60 */ protected set {} } // 0x0000000183AF4DD0-0x0000000183AF4E70 0x0000000183AFC2E0-0x0000000183AFC390
	public uint[] trialAvatarList { /* [XID] */ /* 0x0000000189B44D30-0x0000000189B44D50 */ get => default; /* [XID] */ /* 0x0000000189B4C5A0-0x0000000189B4C5C0 */ protected set {} } // 0x0000000183AFBB10-0x0000000183AFBBC0 0x0000000183AF45E0-0x0000000183AF4690
	public uint[] exclusivePlaceList { /* [XID] */ /* 0x0000000189B53BE0-0x0000000189B53C00 */ get => default; /* [XID] */ /* 0x0000000189B5B470-0x0000000189B5B490 */ protected set {} } // 0x0000000183AF9D60-0x0000000183AF9E10 0x0000000183AF88B0-0x0000000183AF8960

	// Constructors
	public QuestExcelConfig() {} // 0x0000000183AFC430-0x0000000183AFC490

	// Methods
	// [IDTag] // 0x0000000189B62900-0x0000000189B62940
	// [XID] // 0x0000000189B62900-0x0000000189B62940
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183AF6B70-0x0000000183AF88B0
	// [IDTag] // 0x0000000189B6D1A0-0x0000000189B6D1E0
	// [XID] // 0x0000000189B6D1A0-0x0000000189B6D1E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183AF4FC0-0x0000000183AF6B70
	// [XID] // 0x0000000189B77790-0x0000000189B777B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C8E */, bool useObjectPool = false /* Metadata: 0x00AF2C92 */) => default; // 0x0000000183AF9E10-0x0000000183AFB3F0
	[BlackList] // 0x0000000189B7ED00-0x0000000189B7ED40
	// [XID] // 0x0000000189B7ED00-0x0000000189B7ED40
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AF4690-0x0000000183AF4730
	[BlackList] // 0x0000000189B89690-0x0000000189B896D0
	// [XID] // 0x0000000189B89690-0x0000000189B896D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AF4730-0x0000000183AF4890
	[BlackList] // 0x0000000189B93A70-0x0000000189B93AB0
	// [XID] // 0x0000000189B93A70-0x0000000189B93AB0
	public virtual void ReturnToObjectPool() {} // 0x0000000183AFC390-0x0000000183AFC430
	[BlackList] // 0x0000000189B9DC20-0x0000000189B9DC60
	// [XID] // 0x0000000189B9DC20-0x0000000189B9DC60
	public virtual void OnPoolAllocated() {} // 0x0000000183AFC050-0x0000000183AFC0F0
	[BlackList] // 0x0000000189BA8330-0x0000000189BA8370
	// [XID] // 0x0000000189BA8330-0x0000000189BA8370
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AFBFB0-0x0000000183AFC050
}

