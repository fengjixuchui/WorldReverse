/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Area2DAmbienceData // TypeDefIndex: 11234
{
	// Fields
	public ulong hash; // 0x10

	// Properties
	public Area2DAmbience[] areaData { /* [XID] */ /* 0x000000018984BDD0-0x000000018984BE10 */ get; private set; } // 0x000000018329FE70-0x000000018329FED0 0x000000018329FED0-0x000000018329FF30

	// Constructors
	public Area2DAmbienceData() {} // Dummy constructor
	public Area2DAmbienceData(ConfigAudioArea2DAmbience[] configs) {} // 0x000000018329FF30-0x00000001832A0240
	public Area2DAmbienceData(Polygon2 template, int count, AAB2 range) {} // 0x00000001832A0240-0x00000001832A0500

	// Methods
	// [XID] // 0x000000018985D0C0-0x000000018985D0E0
	public static Area2DAmbienceData FromConfig(ConfigAudioArea2DAmbience[] configs) => default; // 0x000000018329FC90-0x000000018329FD60
	// [XID] // 0x0000000189864B70-0x0000000189864B90
	public static Area2DAmbienceData GenerateRandomData(Polygon2 template, int count, AAB2 range) => default; // 0x000000018329FD60-0x000000018329FE70
}

