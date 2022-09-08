/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioPatrollerPlugin : AudioComponentPlugin // TypeDefIndex: 12024
{
	// Fields
	private readonly Action<ThreatLevel, ThreatLevel> _threatLevelCallback; // 0x60
	private ConfigAudioCombat _staticConfig; // 0x68
	private LCAIBeta _aiComponent; // 0x70

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896392C0-0x00000001896392E0 */ get => default; } // 0x0000000183319E70-0x0000000183319F10 

	// Constructors
	public AudioPatrollerPlugin() {} // Dummy constructor
	public AudioPatrollerPlugin(VCBaseAudio component) {} // 0x0000000183319DC0-0x0000000183319E70

	// Methods
	// [XID] // 0x0000000189640720-0x0000000189640740
	public override void Init() {} // 0x0000000183319870-0x0000000183319930
	// [XID] // 0x0000000189648020-0x0000000189648040
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183319CF0-0x0000000183319DC0
	// [XID] // 0x000000018964F6D0-0x000000018964F6F0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183319370-0x0000000183319440
	// [XID] // 0x00000001896570C0-0x00000001896570E0
	public override void Destroy() {} // 0x0000000183319440-0x0000000183319500
	// [XID] // 0x000000018965E7B0-0x000000018965E7D0
	public void UpdateTemperatureSync() {} // 0x00000001833191D0-0x0000000183319370
	// [XID] // 0x0000000189665DC0-0x0000000189665DE0
	private void OnThreadLevelChange(ThreatLevel before, ThreatLevel after) {} // 0x0000000183319500-0x00000001833196E0
	// [XID] // 0x000000018966D550-0x000000018966D570
	private void LocateStaticConfig() {} // 0x0000000183319990-0x0000000183319A50
	// [XID] // 0x0000000189675530-0x0000000189675550
	private void LocateAiComponent() {} // 0x0000000183319BB0-0x0000000183319C80
	// [XID] // 0x000000018967CBA0-0x000000018967CBC0
	private void ForgetAboutAiComponent() {} // 0x00000001833196E0-0x0000000183319780
	// [XID] // 0x00000001896841C0-0x00000001896841E0
	private void RegisterAiCallbacks() {} // 0x0000000183318F80-0x0000000183319070
	// [XID] // 0x000000018968BE70-0x000000018968BE90
	private void UnregisterAiCallbacks() {} // 0x0000000183319780-0x0000000183319870
	// [XID] // 0x0000000189693A10-0x0000000189693A30
	private void MarkSelfAroused() {} // 0x00000001833190E0-0x00000001833191D0
	// [XID] // 0x000000018969AE10-0x000000018969AE30
	private void MarkSelfTranquilized() {} // 0x0000000183319A50-0x0000000183319B40
}

