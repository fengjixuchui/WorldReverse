/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExSoundObject : CriDisposable // TypeDefIndex: 7090
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x00000001877BA9F0-0x00000001877BAA50 

	// Nested types
	private struct Config // TypeDefIndex: 7091
	{
		// Fields
		public bool enableVoiceLimitScope; // 0x00
		public bool enableCategoryCueLimitScope; // 0x01
	}

	// Constructors
	public CriAtomExSoundObject() {} // Dummy constructor
	public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope) {} // 0x00000001877BA380-0x00000001877BA4C0

	// Methods
	public override void Dispose() {} // 0x00000001877BA210-0x00000001877BA2D0
	public void AddPlayer(CriAtomExPlayer player) {} // 0x00000001877BA020-0x00000001877BA0E0
	public void DeletePlayer(CriAtomExPlayer player) {} // 0x00000001877BA150-0x00000001877BA210
	public void DeleteAllPlayers() {} // 0x00000001877BA0E0-0x00000001877BA150
	~CriAtomExSoundObject() {} // 0x00000001877BA2D0-0x00000001877BA380
	private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size); // 0x00000001877BA5C0-0x00000001877BA710
	private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject); // 0x00000001877BA900-0x00000001877BA9F0
	private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player); // 0x00000001877BA4C0-0x00000001877BA5C0
	private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player); // 0x00000001877BA800-0x00000001877BA900
	private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject); // 0x00000001877BA710-0x00000001877BA800
}

