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
public class ConfigGuideWidgetContent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18306
{
	// Fields
	private string _path; // 0x10
	private string _contextName; // 0x18
	private string _hintInfo; // 0x20
	private string _widghtInfo; // 0x28
	private string _warningInfo; // 0x30
	private string[] _whiteContextList; // 0x38
	private InputActionType[] _actionInfoList; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigInputHint[] _inputHintList; // 0x48
	private WidgetInfoPos _widghtInfoPos; // 0x50
	private MaskGuideType _maskType; // 0x54
	private bool _maskPassEasyTouch; // 0x58
	private ButtonGuideType _type; // 0x5C
	private SimpleSafeFloat xOffsetRawNum; // 0x60
	private SimpleSafeFloat yOffsetRawNum; // 0x64
	private SimpleSafeFloat hintOffsetRawNum; // 0x68
	private GuideWidgetSpecialType _special; // 0x6C
	private SimpleSafeFloat valueRawNum; // 0x70
	private string _valueStr; // 0x78
	private GuidePageType _pageType; // 0x80
	private SimpleSafeInt32 maskIndexRawNum; // 0x84

	// Properties
	public string path { /* [XID] */ /* 0x0000000189A57390-0x0000000189A573B0 */ get => default; /* [XID] */ /* 0x0000000189A5EEF0-0x0000000189A5EF10 */ private set {} } // 0x00000001839CEB00-0x00000001839CEBA0 0x00000001839CE850-0x00000001839CE900
	public string contextName { /* [XID] */ /* 0x0000000189A66880-0x0000000189A668A0 */ get => default; /* [XID] */ /* 0x0000000189A6E080-0x0000000189A6E0A0 */ private set {} } // 0x00000001839CD2D0-0x00000001839CD370 0x00000001839CDCB0-0x00000001839CDD60
	public string hintInfo { /* [XID] */ /* 0x0000000189A75510-0x0000000189A75530 */ get => default; /* [XID] */ /* 0x0000000189A7D250-0x0000000189A7D270 */ private set {} } // 0x00000001839CE3D0-0x00000001839CE470 0x00000001839CD7E0-0x00000001839CD890
	public string widghtInfo { /* [XID] */ /* 0x0000000189A84A60-0x0000000189A84A80 */ get => default; /* [XID] */ /* 0x0000000189A8C2F0-0x0000000189A8C310 */ private set {} } // 0x00000001839CE140-0x00000001839CE1E0 0x00000001839CEA50-0x00000001839CEB00
	public string warningInfo { /* [XID] */ /* 0x0000000189A93770-0x0000000189A93790 */ get => default; /* [XID] */ /* 0x0000000189A9B380-0x0000000189A9B3A0 */ private set {} } // 0x00000001839CCC40-0x00000001839CCCE0 0x00000001839CD5D0-0x00000001839CD680
	public string[] whiteContextList { /* [XID] */ /* 0x0000000189AA26C0-0x0000000189AA26E0 */ get => default; /* [XID] */ /* 0x0000000189AA9C40-0x0000000189AA9C60 */ private set {} } // 0x00000001839CD450-0x00000001839CD4F0 0x00000001839CD730-0x00000001839CD7E0
	public InputActionType[] actionInfoList { /* [XID] */ /* 0x0000000189AB1B60-0x0000000189AB1B80 */ get => default; /* [XID] */ /* 0x0000000189AB8E90-0x0000000189AB8EB0 */ private set {} } // 0x00000001839CE900-0x00000001839CE9A0 0x00000001839CF800-0x00000001839CF8B0
	public ConfigInputHint[] inputHintList { /* [XID] */ /* 0x0000000189AC0910-0x0000000189AC0930 */ get => default; /* [XID] */ /* 0x0000000189AC8330-0x0000000189AC8350 */ private set {} } // 0x00000001839CBC80-0x00000001839CBD20 0x00000001839CE630-0x00000001839CE6E0
	public WidgetInfoPos widghtInfoPos { /* [XID] */ /* 0x0000000189ACFB30-0x0000000189ACFB50 */ get => default; /* [XID] */ /* 0x0000000189AD7800-0x0000000189AD7820 */ private set {} } // 0x00000001839CE280-0x00000001839CE320 0x00000001839CD890-0x00000001839CD940
	public MaskGuideType maskType { /* [XID] */ /* 0x0000000189ADF2B0-0x0000000189ADF2D0 */ get => default; /* [XID] */ /* 0x0000000189AE6B30-0x0000000189AE6B50 */ private set {} } // 0x00000001839CB9B0-0x00000001839CBA50 0x00000001839CE320-0x00000001839CE3D0
	public bool maskPassEasyTouch { /* [XID] */ /* 0x0000000189AEE600-0x0000000189AEE620 */ get => default; /* [XID] */ /* 0x0000000189AF5B70-0x0000000189AF5B90 */ private set {} } // 0x00000001839CA320-0x00000001839CA3C0 0x00000001839CD680-0x00000001839CD730
	public ButtonGuideType type { /* [XID] */ /* 0x0000000189AFD090-0x0000000189AFD0B0 */ get => default; /* [XID] */ /* 0x0000000189B048A0-0x0000000189B048C0 */ private set {} } // 0x00000001839CFD70-0x00000001839CFE10 0x00000001839CE9A0-0x00000001839CEA50
	public float xOffset { /* [XID] */ /* 0x0000000189B0C090-0x0000000189B0C0B0 */ get => default; /* [XID] */ /* 0x0000000189B136B0-0x0000000189B136D0 */ private set {} } // 0x00000001839CD370-0x00000001839CD450 0x00000001839CDB20-0x00000001839CDC00
	public float yOffset { /* [XID] */ /* 0x0000000189B1AD80-0x0000000189B1ADA0 */ get => default; /* [XID] */ /* 0x0000000189B22370-0x0000000189B22390 */ private set {} } // 0x00000001839CD4F0-0x00000001839CD5D0 0x00000001839CE470-0x00000001839CE550
	public float hintOffset { /* [XID] */ /* 0x0000000189B298C0-0x0000000189B298E0 */ get => default; /* [XID] */ /* 0x0000000189B30EF0-0x0000000189B30F10 */ private set {} } // 0x00000001839CBDD0-0x00000001839CBEB0 0x00000001839CDD60-0x00000001839CDE40
	public GuideWidgetSpecialType special { /* [XID] */ /* 0x0000000189B38590-0x0000000189B385B0 */ get => default; /* [XID] */ /* 0x0000000189B40000-0x0000000189B40020 */ private set {} } // 0x00000001839CE1E0-0x00000001839CE280 0x00000001839CBD20-0x00000001839CBDD0
	public float value { /* [XID] */ /* 0x0000000189B47860-0x0000000189B47880 */ get => default; /* [XID] */ /* 0x0000000189B4EFF0-0x0000000189B4F010 */ private set {} } // 0x00000001839CCE70-0x00000001839CCF50 0x00000001839CCD90-0x00000001839CCE70
	public string valueStr { /* [XID] */ /* 0x0000000189B56970-0x0000000189B56990 */ get => default; /* [XID] */ /* 0x0000000189B5E1A0-0x0000000189B5E1C0 */ private set {} } // 0x00000001839CFCD0-0x00000001839CFD70 0x00000001839CDC00-0x00000001839CDCB0
	public GuidePageType pageType { /* [XID] */ /* 0x0000000189B656E0-0x0000000189B65700 */ get => default; /* [XID] */ /* 0x0000000189B6CC60-0x0000000189B6CC80 */ private set {} } // 0x00000001839CE7B0-0x00000001839CE850 0x00000001839CCCE0-0x00000001839CCD90
	public int maskIndex { /* [XID] */ /* 0x0000000189B74430-0x0000000189B74450 */ get => default; /* [XID] */ /* 0x0000000189B7BA90-0x0000000189B7BAB0 */ private set {} } // 0x00000001839CE6E0-0x00000001839CE7B0 0x00000001839CE550-0x00000001839CE630

	// Constructors
	public ConfigGuideWidgetContent() {} // 0x00000001839CFEB0-0x00000001839CFF10

	// Methods
	// [XID] // 0x0000000189B83360-0x0000000189B83380
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839CF8B0-0x00000001839CFB90
	// [XID] // 0x0000000189B8A7D0-0x0000000189B8A7F0
	public void InitEmpty() {} // 0x00000001839CD940-0x00000001839CDB20
	[BlackList] // 0x0000000189B91DC0-0x0000000189B91E00
	// [XID] // 0x0000000189B91DC0-0x0000000189B91E00
	public bool FromJson(JSONNode node) => default; // 0x00000001839CCF50-0x00000001839CD2D0
	// [XID] // 0x0000000189B9C2C0-0x0000000189B9C2E0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839CA3C0-0x00000001839CB6E0
	// [XID] // 0x0000000189BA3990-0x0000000189BA39B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93B1 */, bool useObjectPool = false /* Metadata: 0x00AF93B5 */) => default; // 0x00000001839CDE40-0x00000001839CE140
	// [XID] // 0x0000000189BAAE00-0x0000000189BAAE20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93B6 */, bool useObjectPool = false /* Metadata: 0x00AF93BA */) => default; // 0x00000001839CBEB0-0x00000001839CCC40
	[BlackList] // 0x0000000189BB2410-0x0000000189BB2450
	// [XID] // 0x0000000189BB2410-0x0000000189BB2450
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839CB6E0-0x00000001839CB9B0
	// [XID] // 0x0000000189BBC970-0x0000000189BBC990
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839CEBA0-0x00000001839CF800
	[BlackList] // 0x0000000189BC45E0-0x0000000189BC4620
	// [XID] // 0x0000000189BC45E0-0x0000000189BC4620
	public virtual void AutoAllocTypeFields() {} // 0x00000001839CBA50-0x00000001839CBAF0
	[BlackList] // 0x0000000189BCF110-0x0000000189BCF150
	// [XID] // 0x0000000189BCF110-0x0000000189BCF150
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839CBAF0-0x00000001839CBC80
	[BlackList] // 0x0000000189BD9580-0x0000000189BD95C0
	// [XID] // 0x0000000189BD9580-0x0000000189BD95C0
	public virtual void ReturnToObjectPool() {} // 0x00000001839CFE10-0x00000001839CFEB0
	[BlackList] // 0x00000001895E9090-0x00000001895E90D0
	// [XID] // 0x00000001895E9090-0x00000001895E90D0
	public virtual void OnPoolAllocated() {} // 0x00000001839CFC30-0x00000001839CFCD0
	[BlackList] // 0x00000001895F37B0-0x00000001895F37F0
	// [XID] // 0x00000001895F37B0-0x00000001895F37F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839CFB90-0x00000001839CFC30
}

