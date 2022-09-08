/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class InterActionGrp // TypeDefIndex: 20633
{
	// Fields
	public ulong groupId; // 0x10
	public ulong nextGroupId; // 0x18
	public bool isKeyList; // 0x20
	private List<BaseInterAction> _interActionList; // 0x28
	protected bool _isStarted; // 0x30
	private const string INTER_ACTION_NPC_DEFAULT_START = "default_start"; // Metadata: 0x00AFDF0B
	private const string INTER_ACTION_NPC_DEFAULT_FINISH = "default_finish"; // Metadata: 0x00AFDF1C
	private const string INTER_ACTION_NPC_DEFAULT_FINISH_COMPLEX = "default_finish_complex"; // Metadata: 0x00AFDF2E
	public const uint NO_QUEST_ID = 0; // Metadata: 0x00AFDF48
	public const uint FREE_ACTION_QUEST_ID = 0; // Metadata: 0x00AFDF4C

	// Properties
	public bool isStarted { /* [XID] */ /* 0x0000000189A4FB60-0x0000000189A4FB80 */ get => default; } // 0x0000000185B44490-0x0000000185B44530 
	public bool IsFinished { /* [XID] */ /* 0x00000001898F88A0-0x00000001898F88C0 */ get => default; } // 0x0000000185B43D90-0x0000000185B43EE0 
	private static string INTER_ACTION_CFG_PATH { /* [XID] */ /* 0x0000000189A7CEF0-0x0000000189A7CF10 */ get => default; } // 0x0000000185B419B0-0x0000000185B41A50 

	// Constructors
	public InterActionGrp() {} // 0x0000000185B44B40-0x0000000185B44BC0

	// Methods
	// [XID] // 0x0000000189A246D0-0x0000000189A246F0
	public void AddInterAction(BaseInterAction interAction) {} // 0x0000000185B43990-0x0000000185B43AA0
	// [XID] // 0x00000001897334E0-0x0000000189733500
	public int GetInterActionCount() => default; // 0x0000000185B42E50-0x0000000185B42F10
	// [IDTag] // 0x0000000189A33190-0x0000000189A331D0
	// [XID] // 0x0000000189A33190-0x0000000189A331D0
	public BaseInterAction GetInterAction(int index) => default; // 0x0000000185B43EE0-0x0000000185B43FD0
	// [XID] // 0x0000000189A3DBF0-0x0000000189A3DC10
	public bool HasInterActionType(InteractionType type) => default; // 0x0000000185B42600-0x0000000185B42780
	// [IDTag] // 0x0000000189A45370-0x0000000189A453B0
	// [XID] // 0x0000000189A45370-0x0000000189A453B0
	public BaseInterAction GetInterAction(InteractionType type) => default; // 0x0000000185B43FD0-0x0000000185B44150
	// [XID] // 0x0000000189A5EC90-0x0000000189A5ECB0
	public void ReInit() {} // 0x0000000185B42F10-0x0000000185B43030
	// [XID] // 0x0000000189A66430-0x0000000189A66450
	public void ForceFinish() {} // 0x0000000185B424E0-0x0000000185B42600
	// [XID] // 0x0000000189A6DB60-0x0000000189A6DB80
	public void StartExternal() {} // 0x0000000185B41E80-0x0000000185B41FC0
	// [XID] // 0x0000000189A75270-0x0000000189A75290
	public void ClearExternal() {} // 0x0000000185B41A50-0x0000000185B41AF0
	// [XID] // 0x00000001895F5EB0-0x00000001895F5ED0
	private static LCBaseIntee GetTargetIntee(LCBaseIntee ownerIntee, ConfigBaseInterAction cfg) => default; // 0x0000000185B44750-0x0000000185B44900
	// [XID] // 0x0000000189A8C0E0-0x0000000189A8C100
	public static List<InterActionGrp> CreateDefaultStart(LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null) => default; // 0x0000000185B44900-0x0000000185B449D0
	// [XID] // 0x0000000189A93590-0x0000000189A935B0
	public static List<InterActionGrp> CreateDefaultFinish(LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null) => default; // 0x0000000185B44680-0x0000000185B44750
	// [XID] // 0x0000000189A9B060-0x0000000189A9B080
	public static List<InterActionGrp> CreateDefaultFinishComplex(LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null) => default; // 0x0000000185B42C40-0x0000000185B42D10
	// [XID] // 0x0000000189AA23D0-0x0000000189AA23F0
	public static List<InterActionGrp> CreateListByConfigList(List<List<ConfigBaseInterAction>> cfgLists, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null) => default; // 0x0000000185B43030-0x0000000185B431D0
	// [XID] // 0x0000000189AA9960-0x0000000189AA9980
	public static List<InterActionGrp> CreateListByLocalConfigPath(string cfgPath, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null, bool isDefault = false /* Metadata: 0x00AFDEF7 */) => default; // 0x0000000185B43350-0x0000000185B43810
	// [XID] // 0x0000000189AB1740-0x0000000189AB1760
	public static RecycledLinkedList<InterActionGrp> CreateLinkedListByLocalConfigPath(string cfgPath, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null, bool isDefault = false /* Metadata: 0x00AFDEF8 */) => default; // 0x0000000185B42780-0x0000000185B42C40
	// [XID] // 0x0000000189AB8AE0-0x0000000189AB8B00
	public static ConfigInterContainer CreateInterContainerByLocalConfigPath(string cfgPath) => default; // 0x0000000185B43AA0-0x0000000185B43D90
	// [XID] // 0x00000001897B2CE0-0x00000001897B2D00
	public static List<LinkedListNode<InterActionGrp>> CreateListByGrpSet(ConfigInterContainer grpSet, LCBaseIntee ownerIntee, ref Dictionary<ulong, LinkedListNode<InterActionGrp>> idInterGrp, uint questID) => default; // 0x0000000185B41FC0-0x0000000185B424E0
	// [IDTag] // 0x0000000189AC8090-0x0000000189AC80D0
	// [XID] // 0x0000000189AC8090-0x0000000189AC80D0
	public static InterActionGrp CreateByGrpConfig(List<ConfigBaseInterAction> grp, LCBaseIntee ownerIntee, uint mainQuestId, InterActionGrp interActionGrp = null, bool isKeyList = true /* Metadata: 0x00AFDEF9 */) => default; // 0x0000000185B41CB0-0x0000000185B41E80
	// [IDTag] // 0x0000000189AD2B20-0x0000000189AD2B60
	// [XID] // 0x0000000189AD2B20-0x0000000189AD2B60
	public static InterActionGrp CreateByGrpConfig(ConfigBaseInterAction[] grp, LCBaseIntee ownerIntee, uint mainQuestId, InterActionGrp interActionGrp = null, bool isKeyList = true /* Metadata: 0x00AFDEFA */) => default; // 0x0000000185B41AF0-0x0000000185B41CB0
	// [XID] // 0x00000001898134E0-0x0000000189813500
	public static InterActionGrp CreateByConfig(ConfigBaseInterAction cfg, LCBaseIntee ownerIntee, uint mainQuestId, InterActionGrp interActionGrp = null) => default; // 0x0000000185B42D10-0x0000000185B42E50
	// [XID] // 0x0000000189AE5040-0x0000000189AE5060
	public static InterActionGrp CreateByDialogScheme(ConfigDialogScheme dialogConfig, LCBaseIntee ownerIntee, uint mainQuestId, InterActionGrp interActionGrp = null) => default; // 0x0000000185B43810-0x0000000185B43990
	// [XID] // 0x00000001896F7BF0-0x00000001896F7C10
	public static InterActionGrp CreateTalkSelect(ConfigTalkScheme talkConfig, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null, uint questMainId = 0 /* Metadata: 0x00AFDEFB */) => default; // 0x0000000185B431D0-0x0000000185B43350
	// [XID] // 0x000000018970E2F0-0x000000018970E310
	public static InterActionGrp CreateDialogSelect(ConfigTalkScheme talkConfig, ConfigDialogScheme dialogCfg, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null, uint questMainId = 0 /* Metadata: 0x00AFDEFF */) => default; // 0x0000000185B44150-0x0000000185B44330
	// [XID] // 0x0000000189AFB900-0x0000000189AFB920
	public static InterActionGrp CreateDialogNext(uint nextTalkID, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null, uint questMainId = 0 /* Metadata: 0x00AFDF03 */) => default; // 0x0000000185B44330-0x0000000185B44490
	// [XID] // 0x00000001896BDFE0-0x00000001896BE000
	public static InterActionGrp CreateDialogFinish(uint finalCode, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null, uint currTalkID = 0 /* Metadata: 0x00AFDF07 */) => default; // 0x0000000185B449D0-0x0000000185B44B40
	// [XID] // 0x0000000189B0A780-0x0000000189B0A7A0
	public static InterActionGrp CreateDoNothing(float duration, LCBaseIntee ownerIntee, InterActionGrp interActionGrp = null) => default; // 0x0000000185B44530-0x0000000185B44680
}

