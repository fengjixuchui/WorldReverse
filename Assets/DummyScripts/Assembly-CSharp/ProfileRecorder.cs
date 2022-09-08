/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ProfileRecorder : BaseQAModule // TypeDefIndex: 28375
{
	// Fields
	public string api; // 0x10
	public string lastDump; // 0x18
	public string newDump; // 0x20
	private HttpWebRequest httpWebRequest; // 0x28
	private USpiderSetting setting; // 0x30
	private string version; // 0x38
	private string device_model; // 0x40
	private string device_name; // 0x48
	private string operating_system; // 0x50
	private Coroutine recordCoroutine; // 0x58
	private static int maxfailedcount; // 0x00
	private int failedCount; // 0x60
	private bool profiling; // 0x64
	private string dumpTime; // 0x68

	// Nested types
	private struct dataWithRequest // TypeDefIndex: 28376
	{
		// Fields
		public string sendDump; // 0x00
		public HttpWebRequest httpWebRequest; // 0x08
	}

	// Constructors
	public ProfileRecorder() {} // 0x00000001849CB5C0-0x00000001849CB640
	static ProfileRecorder() {} // 0x00000001849CB560-0x00000001849CB5C0

	// Methods
	// [XID] // 0x0000000189AF8730-0x0000000189AF8750
	public override void Start() {} // 0x00000001849CB0F0-0x00000001849CB290
	// [XID] // 0x0000000189AFFD20-0x0000000189AFFD40
	public void Dump(string time) {} // 0x00000001849CA7E0-0x00000001849CA890
	[DebuggerHidden] // 0x0000000189B072F0-0x0000000189B07330
	// [XID] // 0x0000000189B072F0-0x0000000189B07330
	private IEnumerator record() => default; // 0x00000001849CAB10-0x00000001849CAC20
	// [XID] // 0x0000000189B11BB0-0x0000000189B11BD0
	public override void Stop() {} // 0x00000001849CB290-0x00000001849CB380
	// [XID] // 0x0000000189B18EA0-0x0000000189B18EC0
	public override void Tick() {} // 0x00000001849CB380-0x00000001849CB560
	// [XID] // 0x0000000189B20510-0x0000000189B20530
	public void sendDumpString() {} // 0x00000001849CAC20-0x00000001849CB090
	// [XID] // 0x0000000189B27BB0-0x0000000189B27BD0
	public void RequestStreamCallBack(IAsyncResult result) {} // 0x00000001849CA8F0-0x00000001849CAB10
}

