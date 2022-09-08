/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugGMTalkDialogContext : BaseDialogContext // TypeDefIndex: 28607
{
	// Fields
	private MonoInLevelDebugGMTalkDialog _dialogMono; // 0x178
	private static InLevelDebugGMTalkDialogContext _gmTalk; // 0x00
	private const int COMMAND_LENGTH = 20; // Metadata: 0x00B0D9D3
	private const string CUSTOM_COMMAND_CONFIG_FILE_NAME = "Commands.txt"; // Metadata: 0x00B0D9D7
	private static readonly List<string> _commandList; // 0x08
	private static string _customCommandConfigPath; // 0x10
	private int _readPointer; // 0x180
	private StringBuilder _builder; // 0x188

	// Properties
	public static InLevelDebugGMTalkDialogContext gmTalk { /* [XID] */ /* 0x00000001898492D0-0x00000001898492F0 */ get => default; } // 0x000000018552B180-0x000000018552B250 

	// Constructors
	public InLevelDebugGMTalkDialogContext() {} // 0x000000018552D3C0-0x000000018552D4B0
	static InLevelDebugGMTalkDialogContext() {} // 0x000000018552D2E0-0x000000018552D3C0

	// Methods
	// [XID] // 0x0000000189850A70-0x0000000189850A90
	public static void ToggleDebugGMTalkDialog() {} // 0x000000018552C170-0x000000018552C370
	// [XID] // 0x0000000189857E60-0x0000000189857E80
	public static void SaveCommand(string command) {} // 0x000000018552BA30-0x000000018552BD70
	// [XID] // 0x000000018985EF70-0x000000018985EF90
	public static string GetCommand(ref int index) => default; // 0x000000018552C720-0x000000018552C8D0
	// [XID] // 0x0000000189866730-0x0000000189866750
	public override void SetupView() {} // 0x000000018552CEA0-0x000000018552D2E0
	// [XID] // 0x000000018986E030-0x000000018986E050
	public override void ClearView() {} // 0x000000018552B660-0x000000018552B710
	// [XID] // 0x0000000189875460-0x0000000189875480
	protected override void BindViewCallbacks() {} // 0x000000018552B250-0x000000018552B2F0
	// [XID] // 0x000000018987CF90-0x000000018987CFB0
	private void OnInputFinish() {} // 0x000000018552C5B0-0x000000018552C720
	// [XID] // 0x0000000189883F30-0x0000000189883F50
	private void GetPreviousCommand() {} // 0x000000018552BDD0-0x000000018552BF00
	// [XID] // 0x000000018988B610-0x000000018988B630
	private void GetNextCommand() {} // 0x000000018552C490-0x000000018552C5B0
	// [XID] // 0x0000000189892D90-0x0000000189892DB0
	private void RequestCloseDialog() {} // 0x000000018552C3D0-0x000000018552C490
	// [XID] // 0x000000018989A410-0x000000018989A430
	private void AddToCustomCommands() {} // 0x000000018552B2F0-0x000000018552B660
	// [XID] // 0x00000001898A1630-0x00000001898A1650
	private void ClearCustomList() {} // 0x000000018552BF60-0x000000018552C170
	// [XID] // 0x00000001898A8EE0-0x00000001898A8F00
	private void LoadCustomCommands() {} // 0x000000018552C8D0-0x000000018552CEA0
	// [XID] // 0x00000001898B0820-0x00000001898B0840
	private void RefreshLog() {} // 0x000000018552B710-0x000000018552BA30
}

