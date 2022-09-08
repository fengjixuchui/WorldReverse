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
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScreenRecoder : BaseQAModule // TypeDefIndex: 28378
{
	// Fields
	public string api; // 0x10
	private Texture2D tex; // 0x18
	private Rect rect; // 0x20
	private string widthScaled; // 0x30
	private string heightScaled; // 0x38
	private int newWidth; // 0x40
	private int newHeight; // 0x44
	private USpiderSetting setting; // 0x48
	private float autoRecordTimePassed; // 0x50
	private Image floatingWindowImage; // 0x58
	private CanvasGroup descriptionPanelCanvasGroup; // 0x60
	private int screenShotType; // 0x68
	private Color hideColor; // 0x6C
	private Color showColor; // 0x7C
	private string version; // 0x90
	public string deviceName; // 0x98
	public string deviceModel; // 0xA0
	public string operatingSystem; // 0xA8
	public string x; // 0xB0
	public string y; // 0xB8
	public string z; // 0xC0
	public GameObject avatarRoot; // 0xC8
	public Transform avatarTrans; // 0xD0
	private Queue<data> rawQueue; // 0xD8
	public static data saveData; // 0x00
	private static data sendData; // 0x48
	private HttpWebRequest httpWebRequest; // 0xE0
	private Coroutine recordCoroutine; // 0xE8
	private bool stopped; // 0xF0
	private Encoding encode; // 0xF8
	private WaitForEndOfFrame delay; // 0x100

	// Nested types
	public struct data // TypeDefIndex: 28379
	{
		// Fields
		public byte[] Screenshot; // 0x00
		public string userName; // 0x08
		public string time; // 0x10
		public string frame; // 0x18
		public string screenShotType; // 0x20
		public string fps; // 0x28
		public string description; // 0x30
		public string title; // 0x38
		public bool waitForDescription; // 0x40
	}

	// Constructors
	public ScreenRecoder() {} // 0x0000000181A35880-0x0000000181A359F0
	static ScreenRecoder() {} // 0x0000000181A35770-0x0000000181A35880

	// Methods
	// [XID] // 0x0000000189B72920-0x0000000189B72940
	public void resetRawQueue(int newSize) {} // 0x0000000181A34C90-0x0000000181A34D90
	// [XID] // 0x0000000189B79E30-0x0000000189B79E50
	public override void Start() {} // 0x0000000181A34FC0-0x0000000181A352F0
	// [XID] // 0x0000000189B81540-0x0000000189B81560
	public override void Tick() {} // 0x0000000181A353A0-0x0000000181A35770
	// [XID] // 0x0000000189B88C90-0x0000000189B88CB0
	public override void Stop() {} // 0x0000000181A352F0-0x0000000181A353A0
	[DebuggerHidden] // 0x0000000189B901C0-0x0000000189B90200
	// [XID] // 0x0000000189B901C0-0x0000000189B90200
	private IEnumerator record() => default; // 0x0000000181A34E50-0x0000000181A34F60
	// [XID] // 0x0000000189B9A500-0x0000000189B9A520
	public void SendData() {} // 0x0000000181A342A0-0x0000000181A34C90
	// [XID] // 0x0000000189BA1BB0-0x0000000189BA1BD0
	public void AsyncSendCallback(IAsyncResult ar) {} // 0x0000000181A34160-0x0000000181A342A0
}

