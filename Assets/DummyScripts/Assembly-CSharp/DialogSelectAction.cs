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

public sealed class DialogSelectAction : BaseInterAction // TypeDefIndex: 20630
{
	// Fields
	private bool _useGrpId; // 0x48
	private bool _insert; // 0x49
	private ConfigTalkScheme _talkConfig; // 0x50
	private ConfigTalkScheme _talkConfigWithDialog; // 0x58
	private ConfigDialogScheme _dialogConfig; // 0x60
	private List<uint> _nextValidTalkList; // 0x68
	private uint[] _nextValidDialogList; // 0x70
	private List<ulong> _nextActionGrpList; // 0x78
	private TalkSelectTimeOutExcelConfig _talkTimeOutConfig; // 0x80
	private DialogSelectTimeOutExcelConfig _dialogTimeOutConfig; // 0x88

	// Properties
	public bool useGrpId { /* [XID] */ /* 0x00000001899BC690-0x00000001899BC6B0 */ get => default; } // 0x0000000184A01650-0x0000000184A016F0 
	public bool isInsert { /* [XID] */ /* 0x00000001899C4000-0x00000001899C4020 */ get => default; } // 0x0000000184A01790-0x0000000184A01830 
	public ConfigTalkScheme talkConfig { /* [XID] */ /* 0x00000001899D2BF0-0x00000001899D2C10 */ get => default; } // 0x0000000184A01A30-0x0000000184A01AD0 
	public ConfigTalkScheme talkConfigWithDialog { /* [XID] */ /* 0x00000001899E1DA0-0x00000001899E1DC0 */ get => default; } // 0x0000000184A016F0-0x0000000184A01790 
	public ConfigDialogScheme dialogConfig { /* [XID] */ /* 0x00000001899E9110-0x00000001899E9130 */ get => default; } // 0x0000000184A01AD0-0x0000000184A01B70 
	public List<uint> nextValidTalkList { /* [XID] */ /* 0x00000001899F8110-0x00000001899F8130 */ get => default; } // 0x0000000184A01990-0x0000000184A01A30 
	public uint[] nextValidDialogList { /* [XID] */ /* 0x00000001899FF7A0-0x00000001899FF7C0 */ get => default; } // 0x0000000184A01500-0x0000000184A015A0 
	public List<ulong> nextActionGrpList { /* [XID] */ /* 0x0000000189A06F60-0x0000000189A06F80 */ get => default; } // 0x0000000184A01CF0-0x0000000184A01D90 
	public TalkSelectTimeOutExcelConfig talkTimeOutConfig { /* [XID] */ /* 0x0000000189A0E690-0x0000000189A0E6B0 */ get => default; } // 0x0000000184A01B70-0x0000000184A01C20 
	public DialogSelectTimeOutExcelConfig dialogTimeOutConfig { /* [XID] */ /* 0x0000000189A15CC0-0x0000000189A15CE0 */ get => default; } // 0x0000000184A018E0-0x0000000184A01990 

	// Nested types
	public enum DataType // TypeDefIndex: 20631
	{
		INVALID = -1,
		TALK = 0,
		CONFIG = 1
	}

	// Constructors
	public DialogSelectAction() {} // 0x0000000184A01D90-0x0000000184A01E20

	// Methods
	// [XID] // 0x00000001897514C0-0x00000001897514E0
	public void SetInsert(bool value) {} // 0x0000000184A015A0-0x0000000184A01650
	// [XID] // 0x00000001896FF650-0x00000001896FF670
	public void InitWithTalkExcelConfig(ConfigTalkScheme talkConfig) {} // 0x0000000184A01830-0x0000000184A018E0
	// [XID] // 0x000000018971D350-0x000000018971D370
	public void InitWithDialogExcelConfig(ConfigTalkScheme talkConfig, ConfigDialogScheme dialogConfig) {} // 0x0000000184A01C20-0x0000000184A01CF0
	// [XID] // 0x0000000189A1D110-0x0000000189A1D130
	public void Refresh(uint mainQuestId, uint npcConfigId) {} // 0x0000000184A011F0-0x0000000184A01500
}

