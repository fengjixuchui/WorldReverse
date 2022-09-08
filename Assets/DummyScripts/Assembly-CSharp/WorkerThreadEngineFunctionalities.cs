/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorkerThreadEngineFunctionalities : WorkerThreadFunctionalities<SharedEngineFunctionalities> // TypeDefIndex: 11282
{
	// Fields
	private string _delayedLanguage; // 0x20
	private string _motionShareSetName; // 0x28
	private string _controllerSpeakerShareSetName; // 0x30
	private bool _hasLearnedShareSetNames; // 0x38
	private bool _hasSetupAuxDevices; // 0x39

	// Properties
	public ResourceMode resourceMode { /* [XID] */ /* 0x000000018964E100-0x000000018964E120 */ get => default; } // 0x00000001831560C0-0x0000000183156180 
	public string currentLanguage { /* [XID] */ /* 0x00000001896559B0-0x00000001896559D0 */ get => default; } // 0x0000000183155C20-0x0000000183155CE0 
	public MmoronCodecId externalSourceCodecId { /* [XID] */ /* 0x0000000189B80C70-0x0000000189B80C90 */ get => default; } // 0x0000000183156360-0x0000000183156420 
	public bool areExternalSourcesReady { /* [XID] */ /* 0x0000000189664770-0x0000000189664790 */ get => default; } // 0x0000000183156000-0x00000001831560C0 

	// Constructors
	public WorkerThreadEngineFunctionalities() {} // Dummy constructor
	public WorkerThreadEngineFunctionalities(WorkerThreadContext context, SharedEngineFunctionalities data) {} // 0x00000001831564F0-0x0000000183156580

	// Methods
	// [XID] // 0x0000000189B88860-0x0000000189B88880
	public override void Init() {} // 0x0000000183155CE0-0x0000000183155D80
	// [XID] // 0x0000000189BCB560-0x0000000189BCB580
	public override void Tick(TimeSpan deltaTime) {} // 0x0000000183155D80-0x0000000183155F40
	// [XID] // 0x00000001896124E0-0x0000000189612500
	public override void Destroy() {} // 0x0000000183155860-0x0000000183155970
	// [XID] // 0x0000000189682B60-0x0000000189682B80
	public void LoadFullPackageResources() {} // 0x0000000183155F40-0x0000000183156000
	// [XID] // 0x000000018968A780-0x000000018968A7A0
	public void UnloadFullPackageResources() {} // 0x00000001831562A0-0x0000000183156360
	// [XID] // 0x0000000189692430-0x0000000189692450
	public void SetShareSetNames(string motionShareSetName, string controllerSpeakerShareSetName) {} // 0x0000000183156420-0x00000001831564F0
	// [XID] // 0x0000000189699850-0x0000000189699870
	public void SwitchLanguage(string language) {} // 0x0000000183155A40-0x0000000183155C20
	// [XID] // 0x00000001896A0CE0-0x00000001896A0D00
	private void SetupAuxDevicesIfNecessary() {} // 0x0000000183156180-0x00000001831562A0
	// [XID] // 0x00000001896A8230-0x00000001896A8250
	private void SwitchDelayedLanguage() {} // 0x0000000183155970-0x0000000183155A40
}

