/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCExtraInterAction : LCBase // TypeDefIndex: 11728
{
	// Fields
	private string _enterCfg; // 0x130
	private string _exitCfg; // 0x138
	private string _btnCfg; // 0x140

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189751330-0x0000000189751350 */ get => default; } // 0x00000001840CBA30-0x00000001840CBAD0 

	// Constructors
	public LCExtraInterAction() {} // 0x00000001840CB9A0-0x00000001840CBA30

	// Methods
	// [XID] // 0x0000000189A2E290-0x0000000189A2E2B0
	public bool HasBtn() => default; // 0x00000001840CA7A0-0x00000001840CA880
	// [XID] // 0x00000001897603D0-0x00000001897603F0
	public void InitWithCfgPaths(string enterCfg, string exitCfg, string btnCfg) {} // 0x00000001840CB580-0x00000001840CB670
	// [XID] // 0x0000000189767740-0x0000000189767760
	public override void Init() {} // 0x00000001840CB2E0-0x00000001840CB520
	// [XID] // 0x000000018976EE30-0x000000018976EE50
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001840CB750-0x00000001840CB9A0
	// [XID] // 0x00000001898CB030-0x00000001898CB050
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001840CA8F0-0x00000001840CAB30
	// [XID] // 0x000000018977DE90-0x000000018977DEB0
	public override void Destroy() {} // 0x00000001840CAD80-0x00000001840CAFB0
	// [XID] // 0x00000001897857E0-0x0000000189785800
	private void OnFieldEnterHandler(LCBaseIntee intee) {} // 0x00000001840CAB30-0x00000001840CAD80
	// [XID] // 0x000000018978CD00-0x000000018978CD20
	private void OnFieldExitHandler(LCBaseIntee intee) {} // 0x00000001840CAFB0-0x00000001840CB170
	// [XID] // 0x0000000189794180-0x00000001897941A0
	private void OnFieldBtnHandler(LCBaseIntee intee) {} // 0x00000001840CB170-0x00000001840CB2E0
}

