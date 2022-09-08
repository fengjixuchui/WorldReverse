/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RenderTextureWrapper // TypeDefIndex: 31553
{
	// Fields
	private static readonly Dictionary<RenderTextureFormat, RenderTextureFormat[]> _alternativeFormatDict; // 0x00
	private RenderTexture _renderTexture; // 0x10
	private Param _param; // 0x18
	private List<Camera> _cameraList; // 0x38
	public Action onRebindToCameraCallBack; // 0x40

	// Properties
	public RenderTexture content { /* [XID] */ /* 0x0000000189B145D0-0x0000000189B145F0 */ get => default; } // 0x0000000182216770-0x0000000182216810 
	public Param param { /* [XID] */ /* 0x0000000189B1BE10-0x0000000189B1BE30 */ get => default; } // 0x0000000182216AB0-0x0000000182216BB0 
	public int width { /* [XID] */ /* 0x0000000189B23530-0x0000000189B23550 */ get => default; } // 0x0000000182216530-0x00000001822165F0 
	public int height { /* [XID] */ /* 0x0000000189B2A7F0-0x0000000189B2A810 */ get => default; } // 0x00000001822169F0-0x0000000182216AB0 

	// Nested types
	public struct Param // TypeDefIndex: 31554
	{
		// Fields
		public int width; // 0x00
		public int height; // 0x04
		public int depth; // 0x08
		public RenderTextureFormat format; // 0x0C
		public RenderTextureReadWrite readWrite; // 0x10
		public string name; // 0x18
	}

	// Constructors
	public RenderTextureWrapper() {} // 0x0000000182216CB0-0x0000000182216D40
	static RenderTextureWrapper() {} // 0x0000000182216BB0-0x0000000182216CB0

	// Methods
	// [XID] // 0x0000000189B31D60-0x0000000189B31D80
	public bool IsValid() => default; // 0x0000000182215760-0x0000000182215830
	// [XID] // 0x0000000189B394F0-0x0000000189B39510
	public void Create(Param param) {} // 0x00000001822159C0-0x0000000182216330
	// [XID] // 0x0000000189B40E10-0x0000000189B40E30
	public void __Release() {} // 0x0000000182216810-0x00000001822169F0
	// [XID] // 0x0000000189B487A0-0x0000000189B487C0
	public bool IsCreated() => default; // 0x0000000182216330-0x00000001822163E0
	// [XID] // 0x0000000189B4FEA0-0x0000000189B4FEC0
	public bool BindToCamera(Camera camera) => default; // 0x00000001822163E0-0x0000000182216530
	// [XID] // 0x0000000189B576E0-0x0000000189B57700
	public bool UnbindFromCamera(Camera camera) => default; // 0x00000001822165F0-0x0000000182216770
	// [XID] // 0x0000000189B5F070-0x0000000189B5F090
	public void RebindToCamera() {} // 0x0000000182215830-0x00000001822159C0
	// [XID] // 0x0000000189B66660-0x0000000189B66680
	public static implicit operator RenderTexture(RenderTextureWrapper wrapper) => default; // 0x00000001822156B0-0x0000000182215760
}

