/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigTalkScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14943
{
	// Fields
	private uint _id; // 0x10
	private TalkBeginWay _beginWay; // 0x14
	private PlayMode _activeMode; // 0x18
	private LogicType _beginCondComb; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private TalkCondEx[] _beginCond; // 0x20
	private uint _priority; // 0x28
	private uint[] _nextTalks; // 0x30
	private uint _initDialog; // 0x38
	private uint[] _npcId; // 0x40
	private string _performCfg; // 0x48
	private TalkHeroType _heroTalk; // 0x50
	private TalkLoadType _loadType; // 0x54
	private uint _questId; // 0x58
	private uint[] _extraLoadMarkId; // 0x60
	private ulong _assetIndex; // 0x68
	private bool _dontBlockDaily; // 0x70
	private uint[] _participantId; // 0x78
	private string _prePerformCfg; // 0x80
	private bool _stayFreeStyle; // 0x88
	private bool _enableCameraDisplacement; // 0x89
	private bool _lockGameTime; // 0x8A
	private TalkMarkType _talkMarkType; // 0x8C
	private bool _questIdleTalk; // 0x90
	private bool _lowPriority; // 0x91
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private TalkExecEx[] _finishExec; // 0x98
	public bool setToBeRemove; // 0xA0
	private List<uint> _nextValidTalkList; // 0xA8

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896289C0-0x00000001896289E0 */ get => default; /* [XID] */ /* 0x0000000189649620-0x0000000189649640 */ private set {} } // 0x0000000184497380-0x0000000184497420 0x0000000184494D10-0x0000000184494DC0
	public TalkBeginWay beginWay { /* [XID] */ /* 0x0000000189716F50-0x0000000189716F70 */ get => default; /* [XID] */ /* 0x0000000189658510-0x0000000189658530 */ private set {} } // 0x0000000184495410-0x00000001844954B0 0x0000000184494590-0x0000000184494640
	public PlayMode activeMode { /* [XID] */ /* 0x000000018965FA40-0x000000018965FA60 */ get => default; /* [XID] */ /* 0x00000001896674F0-0x0000000189667510 */ private set {} } // 0x0000000184496E40-0x0000000184496EE0 0x0000000184494900-0x00000001844949B0
	public LogicType beginCondComb { /* [XID] */ /* 0x000000018966ED00-0x000000018966ED20 */ get => default; /* [XID] */ /* 0x0000000189676720-0x0000000189676740 */ private set {} } // 0x0000000184493A60-0x0000000184493B00 0x0000000184494850-0x0000000184494900
	public TalkCondEx[] beginCond { /* [XID] */ /* 0x0000000189BD8870-0x0000000189BD8890 */ get => default; /* [XID] */ /* 0x0000000189685700-0x0000000189685720 */ private set {} } // 0x0000000184493870-0x0000000184493910 0x0000000184495360-0x0000000184495410
	public uint priority { /* [XID] */ /* 0x00000001896D5BB0-0x00000001896D5BD0 */ get => default; /* [XID] */ /* 0x0000000189694CA0-0x0000000189694CC0 */ private set {} } // 0x00000001844952C0-0x0000000184495360 0x0000000184493910-0x00000001844939C0
	public uint[] nextTalks { /* [XID] */ /* 0x000000018969C420-0x000000018969C440 */ get => default; /* [XID] */ /* 0x00000001896A38C0-0x00000001896A38E0 */ private set {} } // 0x00000001844939C0-0x0000000184493A60 0x0000000184494640-0x00000001844946F0
	public uint initDialog { /* [XID] */ /* 0x00000001896AAD50-0x00000001896AAD70 */ get => default; /* [XID] */ /* 0x00000001896B1D90-0x00000001896B1DB0 */ private set {} } // 0x0000000184493BD0-0x0000000184493C70 0x0000000184491A50-0x0000000184491B00
	public uint[] npcId { /* [XID] */ /* 0x00000001896B9830-0x00000001896B9850 */ get => default; /* [XID] */ /* 0x00000001896C0B60-0x00000001896C0B80 */ private set {} } // 0x0000000184493720-0x00000001844937C0 0x0000000184495210-0x00000001844952C0
	public string performCfg { /* [XID] */ /* 0x00000001898D27B0-0x00000001898D27D0 */ get => default; /* [XID] */ /* 0x00000001896CFBF0-0x00000001896CFC10 */ private set {} } // 0x0000000184494390-0x0000000184494430 0x0000000184495550-0x0000000184495600
	public TalkHeroType heroTalk { /* [XID] */ /* 0x000000018989B4D0-0x000000018989B4F0 */ get => default; /* [XID] */ /* 0x00000001896DE660-0x00000001896DE680 */ private set {} } // 0x0000000184497420-0x00000001844974C0 0x0000000184493670-0x0000000184493720
	public TalkLoadType loadType { /* [XID] */ /* 0x00000001896E4A30-0x00000001896E4A50 */ get => default; /* [XID] */ /* 0x00000001896ED040-0x00000001896ED060 */ private set {} } // 0x00000001844924C0-0x0000000184492560 0x0000000184495E40-0x0000000184495EF0
	public uint questId { /* [XID] */ /* 0x00000001897082F0-0x0000000189708310 */ get => default; /* [XID] */ /* 0x00000001896FC130-0x00000001896FC150 */ private set {} } // 0x0000000184493520-0x00000001844935C0 0x00000001844944E0-0x0000000184494590
	public uint[] extraLoadMarkId { /* [XID] */ /* 0x00000001897036F0-0x0000000189703710 */ get => default; /* [XID] */ /* 0x000000018970AD40-0x000000018970AD60 */ private set {} } // 0x0000000184493C70-0x0000000184493D10 0x0000000184495D90-0x0000000184495E40
	public ulong assetIndex { /* [XID] */ /* 0x00000001897125F0-0x0000000189712610 */ get => default; /* [XID] */ /* 0x0000000189719E70-0x0000000189719E90 */ private set {} } // 0x0000000184497570-0x0000000184497610 0x00000001844947A0-0x0000000184494850
	public bool dontBlockDaily { /* [XID] */ /* 0x0000000189721370-0x0000000189721390 */ get => default; /* [XID] */ /* 0x0000000189728990-0x00000001897289B0 */ private set {} } // 0x00000001844954B0-0x0000000184495550 0x0000000184495A70-0x0000000184495B20
	public uint[] participantId { /* [XID] */ /* 0x00000001897301C0-0x00000001897301E0 */ get => default; /* [XID] */ /* 0x0000000189737B80-0x0000000189737BA0 */ private set {} } // 0x0000000184492380-0x0000000184492420 0x0000000184494A60-0x0000000184494B10
	public string prePerformCfg { /* [XID] */ /* 0x000000018973F6C0-0x000000018973F6E0 */ get => default; /* [XID] */ /* 0x0000000189746A40-0x0000000189746A60 */ private set {} } // 0x0000000184491CD0-0x0000000184491D80 0x0000000184491D80-0x0000000184491E30
	public bool stayFreeStyle { /* [XID] */ /* 0x0000000189785980-0x00000001897859A0 */ get => default; /* [XID] */ /* 0x0000000189755A50-0x0000000189755A70 */ private set {} } // 0x0000000184494430-0x00000001844944E0 0x0000000184492560-0x0000000184492610
	public bool enableCameraDisplacement { /* [XID] */ /* 0x000000018975CD70-0x000000018975CD90 */ get => default; /* [XID] */ /* 0x00000001897645C0-0x00000001897645E0 */ private set {} } // 0x0000000184495600-0x00000001844956B0 0x0000000184494B10-0x0000000184494BC0
	public bool lockGameTime { /* [XID] */ /* 0x0000000189760510-0x0000000189760530 */ get => default; /* [XID] */ /* 0x0000000189773380-0x00000001897733A0 */ private set {} } // 0x0000000184497610-0x00000001844976C0 0x0000000184495BD0-0x0000000184495C80
	public TalkMarkType talkMarkType { /* [XID] */ /* 0x000000018977AA60-0x000000018977AA80 */ get => default; /* [XID] */ /* 0x0000000189782640-0x0000000189782660 */ private set {} } // 0x0000000184492420-0x00000001844924C0 0x00000001844974C0-0x0000000184497570
	public bool questIdleTalk { /* [XID] */ /* 0x0000000189706A20-0x0000000189706A40 */ get => default; /* [XID] */ /* 0x0000000189791150-0x0000000189791170 */ private set {} } // 0x00000001844937C0-0x0000000184493870 0x00000001844949B0-0x0000000184494A60
	public bool lowPriority { /* [XID] */ /* 0x00000001896DD0E0-0x00000001896DD100 */ get => default; /* [XID] */ /* 0x00000001897A0730-0x00000001897A0750 */ private set {} } // 0x00000001844922D0-0x0000000184492380 0x0000000184495B20-0x0000000184495BD0
	public TalkExecEx[] finishExec { /* [XID] */ /* 0x00000001897A7D20-0x00000001897A7D40 */ get => default; /* [XID] */ /* 0x00000001897AF790-0x00000001897AF7B0 */ private set {} } // 0x000000018448FFF0-0x00000001844900A0 0x00000001844935C0-0x0000000184493670
	public uint realQuestId { /* [XID] */ /* 0x00000001898355D0-0x00000001898355F0 */ get => default; } // 0x0000000184493B00-0x0000000184493BD0 
	public List<uint> nextValidTalkList { /* [XID] */ /* 0x0000000189847270-0x0000000189847290 */ get => default; } // 0x00000001844946F0-0x00000001844947A0 

	// Constructors
	public ConfigTalkScheme(uint id, PlayMode activeMode, ulong assetIndex, TalkCondEx[] beginCond, LogicType beginCondComb, TalkBeginWay beginWay, TalkHeroType heroTalk, uint initDialog, uint[] nextTalks, uint[] npcId, string performCfg, uint priority, uint questId) {} // 0x0000000184497800-0x0000000184497990
	public ConfigTalkScheme() {} // 0x0000000184497760-0x0000000184497800

	// Methods
	// [XID] // 0x00000001897B7650-0x00000001897B7670
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184496EE0-0x0000000184497240
	// [XID] // 0x00000001897BF530-0x00000001897BF550
	public void InitEmpty() {} // 0x0000000184494BC0-0x0000000184494D10
	[BlackList] // 0x00000001897C6C40-0x00000001897C6C80
	// [XID] // 0x00000001897C6C40-0x00000001897C6C80
	public bool FromJson(JSONNode node) => default; // 0x0000000184493D10-0x0000000184494090
	// [XID] // 0x00000001897D0FB0-0x00000001897D0FD0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001844900A0-0x0000000184491550
	// [XID] // 0x00000001897D8F70-0x00000001897D8F90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB1E */, bool useObjectPool = false /* Metadata: 0x00AEFB22 */) => default; // 0x0000000184494F10-0x0000000184495210
	// [XID] // 0x00000001897E01F0-0x00000001897E0210
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB23 */, bool useObjectPool = false /* Metadata: 0x00AEFB27 */) => default; // 0x0000000184492610-0x0000000184493520
	[BlackList] // 0x00000001897E7890-0x00000001897E78D0
	// [XID] // 0x00000001897E7890-0x00000001897E78D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184491780-0x0000000184491A50
	// [XID] // 0x00000001897F27B0-0x00000001897F27D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184495EF0-0x0000000184496E40
	[BlackList] // 0x00000001897F9F80-0x00000001897F9FC0
	// [XID] // 0x00000001897F9F80-0x00000001897F9FC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184491B00-0x0000000184491BA0
	[BlackList] // 0x00000001898043D0-0x0000000189804410
	// [XID] // 0x00000001898043D0-0x0000000189804410
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184491BA0-0x0000000184491CD0
	[BlackList] // 0x000000018980E9D0-0x000000018980EA10
	// [XID] // 0x000000018980E9D0-0x000000018980EA10
	public virtual void ReturnToObjectPool() {} // 0x00000001844976C0-0x0000000184497760
	[BlackList] // 0x0000000189819610-0x0000000189819650
	// [XID] // 0x0000000189819610-0x0000000189819650
	public virtual void OnPoolAllocated() {} // 0x00000001844972E0-0x0000000184497380
	[BlackList] // 0x0000000189823730-0x0000000189823770
	// [XID] // 0x0000000189823730-0x0000000189823770
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184497240-0x00000001844972E0
	// [XID] // 0x00000001896FF670-0x00000001896FF690
	public bool IsNeedBeHold(uint npcConfigId) => default; // 0x0000000184494DC0-0x0000000184494F10
	// [IDTag] // 0x000000018983CDB0-0x000000018983CDF0
	// [XID] // 0x000000018983CDB0-0x000000018983CDF0
	public static void GenNextValidTalkList(uint[] nextTalks, ref List<uint> nextValidTalkList, uint mainQuestId, uint npcConfigId) {} // 0x0000000184494190-0x0000000184494390
	// [IDTag] // 0x000000018984E8E0-0x000000018984E920
	// [XID] // 0x000000018984E8E0-0x000000018984E920
	public List<uint> GenNextValidTalkList(uint mainQuestId, uint npcConfigId) => default; // 0x0000000184494090-0x0000000184494190
	// [XID] // 0x0000000189858C40-0x0000000189858C60
	public bool IsActive() => default; // 0x000000018448FE30-0x000000018448FFF0
	// [XID] // 0x0000000189819B10-0x0000000189819B30
	public bool IsParticipantValid() => default; // 0x00000001844956B0-0x0000000184495A70
	// [XID] // 0x00000001898674F0-0x0000000189867510
	public bool IsValid(bool defaultValid, uint mainQuestId, uint npcConfigId) => default; // 0x0000000184491550-0x0000000184491780
	// [XID] // 0x000000018986ECD0-0x000000018986ECF0
	private bool GetLogicResult(LogicType logicType, List<bool> valueList) => default; // 0x0000000184491E30-0x00000001844922D0
	// [XID] // 0x0000000189876180-0x00000001898761A0
	private int GetTrueValueCount(List<bool> valueList, int startIndex, int endIndex) => default; // 0x0000000184495C80-0x0000000184495D90
}

