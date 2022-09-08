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

public sealed class TipsTextDialogContext : BaseDialogContext // TypeDefIndex: 29327
{
	// Fields
	private MonoTipsTextDialog _dialogMono; // 0x178
	private string _message; // 0x180
	private float _nextTimeStamp; // 0x188
	private InfoState _infoState; // 0x18C

	// Properties
	public string tips { /* [XID] */ /* 0x0000000189934C30-0x0000000189934C50 */ set {} } // 0x0000000184947330-0x0000000184947440

	// Nested types
	private enum InfoState // TypeDefIndex: 29328
	{
		ForceShow = 0,
		WaitToClose = 1,
		FadeOut = 2
	}

	// Constructors
	public TipsTextDialogContext() {} // Dummy constructor
	public TipsTextDialogContext(string message) {} // 0x0000000184947690-0x0000000184947780

	// Methods
	// [XID] // 0x000000018991E810-0x000000018991E830
	public override void SetupView() {} // 0x0000000184947440-0x0000000184947530
	// [XID] // 0x00000001899260B0-0x00000001899260D0
	public override void UpdateView() {} // 0x0000000184947530-0x0000000184947690
	// [XID] // 0x000000018992D780-0x000000018992D7A0
	public void ReplayDialog() {} // 0x00000001849471A0-0x0000000184947270
}

