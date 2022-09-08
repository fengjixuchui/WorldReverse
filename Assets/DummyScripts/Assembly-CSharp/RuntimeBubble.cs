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

public class RuntimeBubble : IDialogVoiceEventResponder // TypeDefIndex: 21160
{
	// Fields
	private static float LOOP_INTERVAL_MIN; // 0x00
	private uint _npcId; // 0x10
	private uint _dialogId; // 0x14
	private uint _mainQuestId; // 0x18
	private float _duration; // 0x1C
	private float _intervalMin; // 0x20
	private float _intervalMax; // 0x24
	private bool _isLoop; // 0x28
	private NormalTimer _displayTimer; // 0x30
	private NormalTimer _waitTimer; // 0x38
	private LuaSpeechBubbleTask _owner; // 0x40
	private bool _voicePlaying; // 0x48

	// Properties
	public uint npcId { /* [XID] */ /* 0x0000000189766B80-0x0000000189766BA0 */ get => default; } // 0x00000001852188F0-0x0000000185218990 

	// Constructors
	public RuntimeBubble() {} // Dummy constructor
	public RuntimeBubble(LuaSpeechBubbleTask owner) {} // 0x00000001852191A0-0x00000001852192A0
	static RuntimeBubble() {} // 0x0000000185219140-0x00000001852191A0

	// Methods
	// [XID] // 0x000000018976E120-0x000000018976E140
	public void Initialize(uint npcId, uint mainQuestId, uint dialogId, float duration, float intervalMin, float intervalMax, bool isLoop) {} // 0x0000000185218D80-0x0000000185218F00
	// [XID] // 0x0000000189775960-0x0000000189775980
	public void RestartWaitTimer() {} // 0x0000000185218F00-0x0000000185219070
	// [XID] // 0x000000018977D1E0-0x000000018977D200
	private void TryTriggerBubble() {} // 0x00000001852184F0-0x0000000185218730
	// [XID] // 0x0000000189784BE0-0x0000000189784C00
	public void Tick() {} // 0x0000000185218AC0-0x0000000185218D80
	// [XID] // 0x000000018978C150-0x000000018978C170
	public void StopBubble() {} // 0x0000000185218990-0x0000000185218AC0
	// [XID] // 0x0000000189793680-0x00000001897936A0
	public void RespondToDialogVoiceEvent(uint dialogId, bool startPlaying) {} // 0x0000000185219070-0x0000000185219140
	// [XID] // 0x000000018979B8B0-0x000000018979B8D0
	private float GetDefaultDuration() => default; // 0x0000000185218730-0x0000000185218810
	// [XID] // 0x00000001897A2CA0-0x00000001897A2CC0
	private float GetDefaultExDuration() => default; // 0x0000000185218810-0x00000001852188F0
}

