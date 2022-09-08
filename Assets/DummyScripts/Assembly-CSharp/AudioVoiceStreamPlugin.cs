/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioVoiceStreamPlugin : AudioComponentPlugin, IExternalSourceVoiceStartResponder, IExternalSourceVoiceStopResponder // TypeDefIndex: 12031
{
	// Fields
	private readonly EntityVoicePipeline _pipeline; // 0x60

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018975B810-0x000000018975B830 */ get; } // 0x0000000182115690-0x0000000182115730 
	protected EntityVoicePipeline pipeline { /* [XID] */ /* 0x0000000189763240-0x0000000189763260 */ get; } // 0x0000000182114D90-0x0000000182114E30 

	// Constructors
	protected AudioVoiceStreamPlugin() {} // Dummy constructor
	public AudioVoiceStreamPlugin(VCBaseAudio component, EntityVoicePipeline pipeline) {} // 0x0000000182115600-0x0000000182115690

	// Methods
	// [XID] // 0x000000018976AA10-0x000000018976AA30
	void MoleMole.Audio.IExternalSourceVoiceStartResponder.RespondToExternalSourceVoiceStart(ExternalSourceVoiceIntention intention, int stub) {} // 0x0000000182115090-0x00000001821151C0
	// [XID] // 0x0000000189771FF0-0x0000000189772010
	void MoleMole.Audio.IExternalSourceVoiceStopResponder.RespondToExternalSourceVoiceStop(ExternalSourceVoiceIntention intention, int stub) {} // 0x00000001821151C0-0x00000001821152F0
	// [XID] // 0x0000000189779820-0x0000000189779840
	public override void OnEnable() {} // 0x0000000182115490-0x0000000182115550
	// [XID] // 0x00000001897811A0-0x00000001897811C0
	public override void OnDisable() {} // 0x00000001821153D0-0x0000000182115490
	// [XID] // 0x0000000189788660-0x0000000189788680
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001821152F0-0x00000001821153D0
	// [XID] // 0x00000001899EE750-0x00000001899EE770
	public virtual int Submit(IVoiceIntention intention) => default; // 0x0000000182114B80-0x0000000182114CD0
	// [XID] // 0x0000000189797570-0x0000000189797590
	public virtual void Drop(int stub) {} // 0x0000000182114860-0x0000000182114920
	// [XID] // 0x000000018979F470-0x000000018979F490
	public virtual void DropAll() {} // 0x0000000182114FE0-0x0000000182115090
	// [XID] // 0x000000018973E400-0x000000018973E420
	public virtual void StopCurrent() {} // 0x0000000182114CD0-0x0000000182114D90
	// [XID] // 0x0000000189745690-0x00000001897456B0
	protected virtual void StopCurrentInOwnPipiline() {} // 0x0000000182115550-0x0000000182115600
	// [XID] // 0x00000001897B62B0-0x00000001897B62D0
	protected virtual void StopCurrentInTeamPipeline() {} // 0x0000000182114E30-0x0000000182114F70
	// [XID] // 0x00000001897547F0-0x0000000189754810
	protected virtual AudioVoiceStreamPlugin GetTeamEntityVoiceStreamPlugin() => default; // 0x0000000182114A00-0x0000000182114B20
}

