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

public sealed class TalkLogDialogContext : BaseDialogContext // TypeDefIndex: 29323
{
	// Fields
	private const string TALKLOGROW_PREFAB_PATH = "ART/UI/Menus/Widget/TalklogRow"; // Metadata: 0x00B0F5D1
	private uint _mainQuestID; // 0x178
	private MonoTalkLogDialog _dialogMono; // 0x180
	private uint _talkLogRowPrefabHandle; // 0x188

	// Constructors
	public TalkLogDialogContext() {} // Dummy constructor
	public TalkLogDialogContext(uint mainQuestID) {} // 0x0000000182B77050-0x0000000182B77110

	// Methods
	// [XID] // 0x0000000189892CF0-0x0000000189892D10
	public override void SetupView() {} // 0x0000000182B76ED0-0x0000000182B77050
	// [XID] // 0x000000018989A350-0x000000018989A370
	protected override void BindViewCallbacks() {} // 0x0000000182B769F0-0x0000000182B76AF0
	// [XID] // 0x00000001898A15B0-0x00000001898A15D0
	public override void ClearView() {} // 0x0000000182B76AF0-0x0000000182B76C10
	// [XID] // 0x00000001898A8E00-0x00000001898A8E20
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182B76DC0-0x0000000182B76ED0
	// [XID] // 0x00000001898B07A0-0x00000001898B07C0
	private void Refresh(GetQuestTalkHistoryRsp rsp) {} // 0x0000000182B76940-0x0000000182B769F0
}

