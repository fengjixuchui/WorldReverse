/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCNpcModel : VCBaseModel // TypeDefIndex: 11921
{
	// Fields
	private static string CHANGE_TRIGGER_KEYWORD_ID; // 0x00
	private static int CHANGE_TRIGGER_PROPERTY_ID; // 0x08
	public static int CHANGE_COLOR_PROPERTY_ID; // 0x0C
	private const int MAX_CHANNEL = 10; // Metadata: 0x00AEAF4D
	private static int[] _UseMaterialIDArr; // 0x10
	private static int[] _ColorIDArr; // 0x18

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A73340-0x0000000189A73360 */ get => default; } // 0x0000000184A3EFB0-0x0000000184A3F050 

	// Constructors
	static VCNpcModel() {} // 0x0000000184A3ECC0-0x0000000184A3EF50
	public VCNpcModel() {} // 0x0000000184A3EF50-0x0000000184A3EFB0

	// Methods
	// [XID] // 0x0000000189A7AE30-0x0000000189A7AE50
	public override void Init() {} // 0x0000000184A3E130-0x0000000184A3E590
	// [XID] // 0x000000018969F760-0x000000018969F780
	public static void ChangeMatColor(Transform trans, int matIndex, Color color) {} // 0x0000000184A3E590-0x0000000184A3E800
	// [XID] // 0x0000000189A89CE0-0x0000000189A89D00
	private static int GetUseMaterialID(int channel) => default; // 0x0000000184A3DAD0-0x0000000184A3DC20
	// [XID] // 0x0000000189A913E0-0x0000000189A91400
	private static int GetColorID(int channel) => default; // 0x0000000184A3EB50-0x0000000184A3ECC0
	// [XID] // 0x00000001896B5720-0x00000001896B5740
	public static void ChangeMatColorForChannel(Transform trans, int matIndex, int channel, Color color) {} // 0x0000000184A3DE90-0x0000000184A3E130
	// [XID] // 0x0000000189B43C90-0x0000000189B43CB0
	public void AddTextureStreamingPreloader() {} // 0x0000000184A3DC20-0x0000000184A3DE90
	// [XID] // 0x00000001896EA7E0-0x00000001896EA800
	public void RemoveTextureStreamingPreloader() {} // 0x0000000184A3E800-0x0000000184A3EAE0
}

