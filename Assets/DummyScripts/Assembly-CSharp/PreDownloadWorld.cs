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

public sealed class PreDownloadWorld : BaseManager // TypeDefIndex: 11641
{
	// Fields
	private BundleDownloadJobSystem _preDownloadSystem; // 0x10
	private bool _enabled; // 0x18
	private Action _callBack; // 0x20

	// Constructors
	public PreDownloadWorld() {} // 0x00000001810BB230-0x00000001810BB2A0

	// Methods
	// [XID] // 0x00000001897BE100-0x00000001897BE120
	public override void Init() {} // 0x00000001810BAD60-0x00000001810BAE00
	// [XID] // 0x000000018970E470-0x000000018970E490
	public override void Destroy() {} // 0x00000001810BA9E0-0x00000001810BAAA0
	// [XID] // 0x00000001896E92C0-0x00000001896E92E0
	public override void Tick() {} // 0x00000001810BB170-0x00000001810BB230
	// [XID] // 0x00000001898EC6C0-0x00000001898EC6E0
	public void Start(Action callBack) {} // 0x00000001810BA930-0x00000001810BA9E0
	// [XID] // 0x00000001897DBBB0-0x00000001897DBBD0
	private void PrepareDownloadComponent(Action callBack) {} // 0x00000001810BAF70-0x00000001810BB170
	// [XID] // 0x0000000189903130-0x0000000189903150
	private void AllComplete(bool resUpdated, bool dataUpdated, bool silenceDataUpdated) {} // 0x00000001810BAE00-0x00000001810BAF70
	// [XID] // 0x0000000189921170-0x0000000189921190
	private void Pause() {} // 0x00000001810BABB0-0x00000001810BAC50
	// [XID] // 0x0000000189946640-0x0000000189946660
	public bool GetDownloadSystemIsPause() => default; // 0x00000001810BAAA0-0x00000001810BAB50
	// [XID] // 0x00000001899586C0-0x00000001899586E0
	public void SetDownloadSystemPause(bool pause) {} // 0x00000001810BA870-0x00000001810BA930
	// [XID] // 0x00000001898019B0-0x00000001898019D0
	public void CancelDownload() {} // 0x00000001810BA7C0-0x00000001810BA870
}

